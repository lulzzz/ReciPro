﻿using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Crystallography.Controls
{
    public partial class CrystalControl : UserControl
    {
        public CrystalControl()
        {
            InitializeComponent();

            formScatteringFactor = new FormScatteringFactor
            {
                crystalControl = this,
                Visible = false
            };

            formSymmetryInformation = new FormSymmetryInformation
            {
                crystalControl = this,
                Visible = false
            };

            formStrain = new FormStrain
            {
                crystalControl = this,
                Visible = false
            };
        }

        public bool SymmetryInformationVisible
        {
            set
            {
                if (formSymmetryInformation.crystal == null)
                    formSymmetryInformation.crystal = Crystal;
                formSymmetryInformation.Visible = value;
            }
            get => formSymmetryInformation.Visible;
        }

        public bool ScatteringFactorVisible
        {
            set
            {
                if (formScatteringFactor.crystal == null)
                    formScatteringFactor.crystal = Crystal;
                formScatteringFactor.Visible = value;
            }
            get => formScatteringFactor.Visible;
        }

        public bool StrainControlVisible { get => formStrain.Visible; }

        public int atomSeriesNum;

        public int SymmetrySeriesNumber
        {
            get
            {
                if (comboBoxCrystalSystem.SelectedIndex >= 0 && comboBoxPointGroup.SelectedIndex >= 0 && comboBoxSpaceGroup.SelectedIndex >= 0)
                    return SymmetryStatic.BelongingNumberOfSymmetry[comboBoxCrystalSystem.SelectedIndex][comboBoxPointGroup.SelectedIndex][comboBoxSpaceGroup.SelectedIndex];
                else return 0;
            }
            set
            {
                if (crystal != null && value >= 0 && value <= SymmetryStatic.TotalSpaceGroupNumber)
                {
                    crystal.SymmetrySeriesNumber = value;
                    (int CrystalSystem, int PointGroup, int SpaceGroup) = SymmetryStatic.GetSytemAndGroupFromSeriesNumber(value);
                    comboBoxCrystalSystem.SelectedIndex = CrystalSystem;
                    comboBoxPointGroup.SelectedIndex = PointGroup;
                    comboBoxSpaceGroup.SelectedIndex = SpaceGroup;
                }
            }
        }

        #region Tabページの表示/非表示プロパティ

        private bool visibleBasicInfoTab = true;
        public bool VisibleBasicInfoTab
        {
            set { this.visibleBasicInfoTab = value; setTabPages(); }
            get => visibleBasicInfoTab;
        }

        private bool visibleElasticityTab = true;

        public bool VisibleElasticityTab
        {
            set { this.visibleElasticityTab = value; setTabPages(); }
            get { return visibleElasticityTab; }
        }

        private bool visibleAtomTab = true;
        public bool VisibleAtomTab
        {
            set { visibleAtomTab = value; setTabPages(); }
            get => visibleAtomTab;
        }

        private bool visibleBondsPolyhedraTab = true;
        public bool VisibleBondsPolyhedraTab
        {
            set { visibleBondsPolyhedraTab = value; setTabPages(); }
            get => visibleBondsPolyhedraTab;
        }

        private bool visibleReferenceTab = true;
        public bool VisibleReferenceTab
        {
            set { visibleReferenceTab = value; setTabPages(); }
            get => visibleReferenceTab;
        }

        private bool visibleEOSTab = true;
        public bool VisibleEOSTab
        {
            set { visibleEOSTab = value; setTabPages(); }
            get { return visibleEOSTab; }
        }

        private bool visibleStressStrainTab = false;
        public bool VisibleStressStrainTab
        {
            set { visibleStressStrainTab = value; setTabPages(); }
            get { return visibleStressStrainTab; }
        }

        private bool visiblePolycrystallineTab = false;
        public bool VisiblePolycrystallineTab
        {
            set { visiblePolycrystallineTab = value; setTabPages(); }
            get { return visiblePolycrystallineTab; }
        }

        private void setTabPages()
        {
            tabControl.TabPages.Clear();
            if (visibleBasicInfoTab) tabControl.TabPages.Add(tabPageBasicInfo);
            if (visibleAtomTab) tabControl.TabPages.Add(tabPageAtom);
            if (visibleBondsPolyhedraTab) tabControl.TabPages.Add(tabPageBondsPolyhedra);
            if (visibleReferenceTab) tabControl.TabPages.Add(tabPageReference);
            if (visibleEOSTab) tabControl.TabPages.Add(tabPageEOS);
            if (visibleElasticityTab) tabControl.TabPages.Add(tabPageElasticity);
            if (visibleStressStrainTab) tabControl.TabPages.Add(tabPageStraingStress);
            if (visiblePolycrystallineTab) tabControl.TabPages.Add(tabPagePolycrystalline);
        }

        #endregion Tabページの表示/非表示プロパティ


        public double[] CellConstants
        {
            get => new[] { numericBoxA.Value, numericBoxB.Value, numericBoxC.Value, numericBoxAlpha.RadianValue, numericBoxBeta.RadianValue, numericBoxGamma.RadianValue };
            set
            {
                if (value != null && value.Length == 6)
                {
                    SkipCellConstantsChangedEvent = true;
                    SkipGenerateCrystal = true;
                    numericBoxA.Value = value[0];
                    numericBoxB.Value = value[1];
                    numericBoxC.Value = value[2];
                    numericBoxAlpha.RadianValue = value[3];
                    numericBoxBeta.RadianValue = value[4];
                    numericBoxGamma.RadianValue = value[5];
                    SkipCellConstantsChangedEvent = false;
                    SkipGenerateCrystal = false;
                    GenerateCrystal();
                    //CrystalChanged?.Invoke(crystal);
                }
            }
        }

        private Crystal crystal;

        public Crystal Crystal
        {
            set
            {
                crystal = value;
                if (crystal != null)
                {
                    Enabled = !crystal.FlexibleMode;
                    checkSpecialNumber();

                    SetForm();
                    //原子位置チェック (strain controlで選択した後、原子位置が変になってしまう問題の修正. 2017/05/29)
                    if (crystal.ChemicalFormulaZ == 1)
                    {
                        for (int i = 0; i < crystal.Atoms.Length; i++)
                            crystal.Atoms[i].ResetSymmetry(SymmetrySeriesNumber);
                        crystal.GetFormulaAndDensity();

                        SetForm();
                    }

                    CrystalChanged?.Invoke(crystal);
                }
            }
            get => crystal;
        }

        public int DefaultTabNumber { set => tabControl.SelectedIndex = value; get => tabControl.SelectedIndex; }

        public delegate void MyEventHandler(Crystal crystal);

        public event MyEventHandler CrystalChanged;

        public FormScatteringFactor formScatteringFactor;
        public FormSymmetryInformation formSymmetryInformation;
        private FormAtomDetailedInfo formAtomDetailedInfo;

        public FormStrain formStrain;

        private void CrystalForm_Load(object sender, System.EventArgs e)
        {
            // groupBoxSymmetry.Size = new Size(tabPageBasicInfo.Width - groupBoxSymmetry.Location.X - 2, groupBoxSymmetry.Size.Height);
            textBoxTitle.Size = new Size(tabPageReference.Width - textBoxTitle.Location.X - 2, tabPageReference.Height - textBoxTitle.Location.Y - 2);

            formScatteringFactor.VisibleChanged += new EventHandler(formScatteringFactor_VisibleChanged);
            formSymmetryInformation.VisibleChanged += new EventHandler(formSymmetryInformation_VisibleChanged);

            //toolTip.SetTooltipToUsercontrol(this);
        }


        public event EventHandler ScatteringFactor_VisibleChanged;
        private void formScatteringFactor_VisibleChanged(object sender, EventArgs e) => ScatteringFactor_VisibleChanged?.Invoke(sender, e);


        public event EventHandler SymmetryInformation_VisibleChanged;
        private void formSymmetryInformation_VisibleChanged(object sender, EventArgs e) => SymmetryInformation_VisibleChanged?.Invoke(sender, e);

        //候補の数値
        private double[] rationalNumbers = new double[] { 1.0 / 12.0, 1.0 / 8.0, 1.0 / 6.0, 1.0 / 4.0, 1.0 / 3.0, 3.0 / 8.0, 5.0 / 12.0, 1.0 / 2.0, 7.0 / 12.0, 5.0 / 8.0, 2.0 / 3.0, 3.0 / 4.0, 5.0 / 6.0, 7.0 / 8.0, 11.0 / 12.0 };

        private void checkSpecialNumber()
        {
            //三方あるいは六方
            // if (crystal.Symmetry.SeriesNumber < 430 && crystal.Symmetry.SeriesNumber > 488) return;
            for (int i = 0; i < crystal.Atoms.Length; i++)
            {
                var pos = new Vector3D(
                    ((int)Math.Round(crystal.Atoms[i].X * 1000000)) / 1000000.0,
                    ((int)Math.Round(crystal.Atoms[i].Y * 1000000)) / 1000000.0,
                    ((int)Math.Round(crystal.Atoms[i].Z * 1000000)) / 1000000.0);
                var occ = ((int)Math.Round(crystal.Atoms[i].Occ * 1000000)) / 1000000.0;

                //bool flag = false;
                for (int j = 0; j < rationalNumbers.Length; j++)
                {
                    if (Math.Abs(rationalNumbers[j] - pos.X) < 0.0001) { pos.X = rationalNumbers[j]; }
                    if (Math.Abs(rationalNumbers[j] - pos.Y) < 0.0001) { pos.Y = rationalNumbers[j]; }
                    if (Math.Abs(rationalNumbers[j] - pos.Z) < 0.0001) { pos.Z = rationalNumbers[j]; }
                    if (Math.Abs(rationalNumbers[j] - occ) < 0.0001) { occ = rationalNumbers[j]; }
                }
                //if (flag)
                {
                    //  Atoms temp = SymmetryStatic.GetEquivalentAtomsPosition(pos, crystal.SymmetrySeriesNumber);
                    //  if (temp.Atom.Count != crystal.Atoms[i].Atom.Count)
                    {
                        Atoms a = crystal.Atoms[i];
                        crystal.Atoms[i] = new Atoms(a.Label, a.AtomicNumber, a.SubNumberXray, a.SubNumberElectron, a.Isotope, a.SymmetrySeriesNumber,
                            pos, new Vector3D(a.X_err, a.Y_err, a.Z_err), occ, a.Occ_err, a.Dsf, new AtomMaterial(a.Argb, a.Ambient, a.Diffusion, a.Specular, a.Shininess, a.Emission, a.Transparency), a.Radius);
                        crystal.GetFormulaAndDensity();
                    }
                }
            }
        }

        #region 対称性コンボの変更イベント

        private bool SkipComboBoxChangeEvent = false;

        private void comboBoxCrystalSystem_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SkipComboBoxChangeEvent = true;
            comboBoxPointGroup.Items.Clear();
            comboBoxSpaceGroup.Items.Clear();
            Symmetry symmetry;
            for (int n = 0; n < SymmetryStatic.BelongingNumberOfSymmetry[comboBoxCrystalSystem.SelectedIndex].Length; n++)
            {
                symmetry = SymmetryStatic.Get_Symmetry(SymmetryStatic.BelongingNumberOfSymmetry[comboBoxCrystalSystem.SelectedIndex][n][0]);
                if (symmetry.CrystalSystemStr == comboBoxCrystalSystem.Text)
                    if (comboBoxPointGroup.Items.Contains(symmetry.PointGroupHMStr) == false)
                        comboBoxPointGroup.Items.Add(symmetry.PointGroupHMStr);
            }
            SkipComboBoxChangeEvent = false;
            comboBoxPointGroup.SelectedIndex = 0;
            comboBoxPointGroup_SelectedIndexChanged(new object(), new System.EventArgs());
        }

        private void comboBoxPointGroup_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (SkipComboBoxChangeEvent) return;
            SkipComboBoxChangeEvent = true;
            comboBoxSpaceGroup.Items.Clear();
            Symmetry symmetry;
            for (int n = 0; n < SymmetryStatic.BelongingNumberOfSymmetry[comboBoxCrystalSystem.SelectedIndex][comboBoxPointGroup.SelectedIndex].Length; n++)
            {
                symmetry = SymmetryStatic.Get_Symmetry(SymmetryStatic.BelongingNumberOfSymmetry[comboBoxCrystalSystem.SelectedIndex][comboBoxPointGroup.SelectedIndex][n]);
                if (symmetry.PointGroupHMStr == comboBoxPointGroup.Text)
                    comboBoxSpaceGroup.Items.Add(symmetry.SpaceGroupHMStr);
            }
            SkipComboBoxChangeEvent = false;
            comboBoxSpaceGroup.SelectedIndex = 0;
            comboBoxSpaceGroup_SelectedIndexChanged(new object(), new System.EventArgs());
        }

        public void comboBoxSpaceGroup_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (SkipComboBoxChangeEvent) return;
            //SymmetrySeriesNumber = SymmetryStatic.BelongingNumberOfSymmetry[comboBoxCrystalSystem.SelectedIndex][comboBoxPointGroup.SelectedIndex][comboBoxSpaceGroup.SelectedIndex];
            SetCellParameterReadOnlyStatus();
            elasticityControl1.SymmetrySeriesNumber = SymmetrySeriesNumber;
            atomControl.SymmetrySeriesNumber = SymmetrySeriesNumber;


        }

        #endregion 対称性コンボの変更イベント

        #region 対称性に従って格子定数コントロールのReadOnlyを変更

        private bool SkipCellConstantsChangedEvent = false;

        private void SetCellParameterReadOnlyStatus()
        {
            if (SkipCellConstantsChangedEvent) return;
            Symmetry tempSym = SymmetryStatic.Get_Symmetry(SymmetrySeriesNumber);
            SkipCellConstantsChangedEvent = true;
            //いったんすべてをreadonly=falseにする
            //numericTextBoxA.Enabled = numericTextBoxB.Enabled = numericTextBoxC.Enabled = numericTextBoxAlpha.Enabled = numericTextBoxBeta.Enabled = numericTextBoxGamma.Enabled = true;
            //numericTextBoxAErr.Enabled = numericTextBoxBErr.Enabled = numericTextBoxCErr.Enabled = numericTextBoxAlphaErr.Enabled = numericTextBoxBetaErr.Enabled = numericTextBoxGammaErr.Enabled = true;
            switch (tempSym.CrystalSystemStr)
            {
                case "Unknown": break;
                case "triclinic":
                    numericBoxA.Enabled = numericBoxB.Enabled = numericBoxC.Enabled = numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = true;
                    break;

                case "monoclinic":
                    numericBoxA.Enabled = numericBoxB.Enabled = numericBoxC.Enabled = true;
                    switch (tempSym.MainAxis)
                    {
                        case "a":
                            numericBoxAlpha.Enabled = true;
                            numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                            numericBoxBeta.Value = numericBoxGamma.Value = 90;
                            numericTextBoxBetaErr.Value = numericTextBoxGammaErr.Value = 0;
                            break;

                        case "b":
                            numericBoxBeta.Enabled = true;
                            numericBoxAlpha.Enabled = numericBoxGamma.Enabled = false;
                            numericBoxAlpha.Value = numericBoxGamma.Value = 90;
                            numericTextBoxAlphaErr.Value = numericTextBoxGammaErr.Value = 0;

                            break;

                        case "c":
                            numericBoxGamma.Enabled = true;
                            numericBoxAlpha.Enabled = numericBoxBeta.Enabled = false;
                            numericBoxAlpha.Value = numericBoxBeta.Value = 90;
                            numericTextBoxAlphaErr.Value = numericTextBoxBetaErr.Value = 0;
                            break;
                    }
                    break;

                case "orthorhombic":
                    numericBoxA.Enabled = numericBoxB.Enabled = numericBoxC.Enabled = true;
                    numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                    numericBoxAlpha.Value = numericBoxBeta.Value = numericBoxGamma.Value = 90;
                    numericTextBoxAlphaErr.Value = numericTextBoxBetaErr.Value = numericTextBoxGammaErr.Value = 0;

                    break;

                case "tetragonal":
                    numericBoxA.Enabled = numericBoxC.Enabled = true;
                    numericBoxB.Enabled = false;
                    numericBoxB.Value = numericBoxA.Value;
                    numericTextBoxBErr.Value = numericTextBoxAErr.Value;
                    numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                    numericBoxAlpha.Value = numericBoxBeta.Value = numericBoxGamma.Value = 90;
                    numericTextBoxAlphaErr.Value = numericTextBoxBetaErr.Value = numericTextBoxGammaErr.Value = 0;
                    break;

                case "trigonal":
                    switch (tempSym.SpaceGroupHMStr.IndexOf("Rho") >= 0 && tempSym.SpaceGroupHMStr.IndexOf("R") >= 0)
                    {
                        case false:
                            numericBoxA.Enabled = numericBoxC.Enabled = true;
                            numericBoxB.Enabled = false;
                            numericBoxB.Value = numericBoxA.Value;
                            numericTextBoxBErr.Value = numericTextBoxAErr.Value;
                            numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                            numericBoxAlpha.Value = numericBoxBeta.Value = 90; numericBoxGamma.Value = 120;
                            numericTextBoxAlphaErr.Value = numericTextBoxBetaErr.Value = numericTextBoxGammaErr.Value = 0;
                            break;

                        case true:
                            numericBoxA.Enabled = true;
                            numericBoxB.Enabled = numericBoxC.Enabled = false;
                            numericBoxC.Value = numericBoxB.Value = numericBoxA.Value;
                            numericTextBoxCErr.Value = numericTextBoxBErr.Value = numericTextBoxAErr.Value;

                            numericBoxAlpha.Enabled = true;
                            numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                            numericBoxGamma.Value = numericBoxBeta.Value = numericBoxAlpha.Value;
                            break;
                    }
                    break;

                case "hexagonal":
                    numericBoxA.Enabled = numericBoxC.Enabled = true;
                    numericBoxB.Enabled = false;
                    numericBoxB.Value = numericBoxA.Value;
                    numericTextBoxBErr.Value = numericTextBoxAErr.Value;
                    numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                    numericBoxAlpha.Value = numericBoxBeta.Value = 90; numericBoxGamma.Value = 120;
                    numericTextBoxAlphaErr.Value = numericTextBoxBetaErr.Value = numericTextBoxGammaErr.Value = 0;
                    break;

                case "cubic":
                    numericBoxA.Enabled = true;
                    numericBoxB.Enabled = numericBoxC.Enabled = false;
                    numericBoxC.Value = numericBoxB.Value = numericBoxA.Value;
                    numericTextBoxCErr.Value = numericTextBoxBErr.Value = numericTextBoxAErr.Value;
                    numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                    numericBoxAlpha.Value = numericBoxBeta.Value = numericBoxGamma.Value = 90;
                    numericTextBoxAlphaErr.Value = numericTextBoxBetaErr.Value = numericTextBoxGammaErr.Value = 0;
                    break;
            }
            numericTextBoxAErr.Enabled = numericBoxA.Enabled;
            numericTextBoxBErr.Enabled = numericBoxB.Enabled;
            numericTextBoxCErr.Enabled = numericBoxC.Enabled;
            numericTextBoxAlphaErr.Enabled = numericBoxAlpha.Enabled;
            numericTextBoxBetaErr.Enabled = numericBoxBeta.Enabled;
            numericTextBoxGammaErr.Enabled = numericBoxGamma.Enabled;

            SkipCellConstantsChangedEvent = false;

            GenerateCrystal();
        }

        private void numericTextBoxErr_ReadOnlyChanged(object sender, EventArgs e)
        {
            numericTextBoxAErr.ReadOnly = numericBoxA.ReadOnly;
            numericTextBoxBErr.ReadOnly = numericBoxB.ReadOnly;
            numericTextBoxCErr.ReadOnly = numericBoxC.ReadOnly;
            numericTextBoxAlphaErr.ReadOnly = numericBoxAlpha.ReadOnly;
            numericTextBoxBetaErr.ReadOnly = numericBoxBeta.ReadOnly;
            numericTextBoxGammaErr.ReadOnly = numericBoxGamma.ReadOnly;
        }

        #endregion 対称性に従って格子定数コントロールのReadOnlyを変更

        private bool SkipGenerateCrystal = false;

        /// <summary>
        /// Formに入力された内容からからCrystalを生成する
        /// </summary>
        public void GenerateCrystal()
        {
            if (SkipGenerateCrystal) return;
            SkipSetForm = true;
            SkipGenerateCrystal = true;
            if (numericBoxA.Value < 0 || numericBoxB.Value < 0 || numericBoxC.Value < 0 || numericBoxAlpha.Value > 180 || numericBoxBeta.Value > 180 || numericBoxGamma.Value > 180)
            {
                MessageBox.Show("0～180の範囲で入力してください");
                return;
            }

            //対称性が変更されているかもしれないので原子も改めて設定しなおす。
            atomControl.ResetSymmetry(SymmetrySeriesNumber);
            var atoms =atomControl.GetAll();

            //Bonds&Polyhedra中のコンボボックスの変更
            bondControl.ElementList = atoms.Select(a => a.ElementName).ToArray();
            var bonds = bondControl.GetAll().ToList();//BondsをListBoxから取得

            Matrix3D rot = null;
            List<Bound> bounds = null;
            List<Bound> latticePlanes = null;
            if (Crystal != null)
            {
                rot = crystal.RotationMatrix;
                bounds = crystal.Bounds;
                latticePlanes = crystal.LatticePlanes;
            }

            crystal = new Crystal(
                numericBoxA.Value / 10, numericBoxB.Value / 10, numericBoxC.Value / 10, numericBoxAlpha.RadianValue, numericBoxBeta.RadianValue, numericBoxGamma.RadianValue,
                numericTextBoxAErr.Value / 10, numericTextBoxBErr.Value / 10, numericTextBoxCErr.Value / 10, numericTextBoxAlphaErr.RadianValue, numericTextBoxBetaErr.RadianValue, numericTextBoxGammaErr.RadianValue,
                SymmetrySeriesNumber, textBoxName.Text, textBoxMemo.Text, colorControl.Color,
                atoms.ToArray(), textBoxAuthor.Text, textBoxJournal.Text, textBoxTitle.Text, bonds);

            if (rot != null) crystal.RotationMatrix = (Matrix3D)rot.Clone();
            if (bounds != null) crystal.Bounds = bounds.ToList();
            if (latticePlanes != null) crystal.LatticePlanes = latticePlanes.ToList();

            crystal.ElasticStiffness = elasticityControl1.Stiffness.ToArray();

            //EOS関連データ （Crystalのコンストラクタに入れた方がいいかも）
            crystal.EOSCondition.A = numericBoxEOS_A.Value;
            crystal.EOSCondition.B = numericBoxEOS_B.Value;
            crystal.EOSCondition.C = numericBoxEOS_C.Value;
            crystal.EOSCondition.CellVolume0 = numericBoxEOS_V0perCell.Value;
            crystal.EOSCondition.Gamma0 = numericBoxEOS_Gamma0.Value;
            crystal.EOSCondition.K0 = numericBoxEOS_KT0.Value;
            crystal.EOSCondition.KperT = numericBoxEOS_KperT.Value;
            crystal.EOSCondition.Kprime0 = numericBoxEOS_KprimeT0.Value;
            crystal.EOSCondition.Q = numericBoxEOS_Q.Value;
            crystal.EOSCondition.T0 = numericBoxEOS_T0.Value;
            crystal.EOSCondition.ThermalPressureApproach = radioButtonMieGruneisen.Checked ? ThermalPressure.MieGruneisen : ThermalPressure.T_dependence_BM;
            crystal.EOSCondition.IsothermalPressureApproach = radioButtonBirchMurnaghan.Checked ? IsothermalPressure.Birch_Murnaghan : IsothermalPressure.Vinet;

            crystal.EOSCondition.Theta0 = numericBoxEOS_Theta0.Value;
            int n = 0;
            for (int i = 0; i < crystal.Atoms.Length; i++)
                n += crystal.Atoms[i].Atom.Count;
            crystal.EOSCondition.Z = crystal.ChemicalFormulaZ;
            if (crystal.ChemicalFormulaZ > 0)
                crystal.EOSCondition.N = n / crystal.ChemicalFormulaZ;
            crystal.DoesUseEOS = checkBoxUseEOS.Checked;
            crystal.EOSCondition.Note = textBoxEOS_Note.Text;
            crystal.EOSCondition.Temperature = numericalTextBoxTemperature.Value;

            //PolyCrystallineProperty
            crystal.AngleResolution = (double)numericUpDownAngleResolution.Value;
            crystal.SubDivision = (int)numericUpDownAngleSubDivision.Value;
            crystal.GrainSize = (double)numericUpDownCrystallineSize.Value;
            if (poleFigureControl.Crystal != null)
                crystal.Crystallites = poleFigureControl.Crystal.Crystallites;

            SkipSetForm = false;

            SetForm(false);

            CrystalChanged?.Invoke(Crystal);
            SkipGenerateCrystal = false;
        }

        public void SetForm()
        {
            SetForm(true);
        }

        public bool SkipSetForm = false;

        /// <summary>
        /// 現在のCrystalによってFormのテキストボックスなどを設定する。
        /// </summary>
        /// <param name="ChangeCellParameter">コントロールのCellParaterを変化させた時はFalse</param>
        public void SetForm(bool ChangeCellParameter)
        {
            if (SkipSetForm) return;
            SkipGenerateCrystal = true;

            colorControl.Color = Color.FromArgb(Crystal.Argb);
            textBoxName.Text = Crystal.Name;
            textBoxMemo.Text = Crystal.Note;

            textBoxAuthor.Text = Crystal.PublAuthorName;
            textBoxJournal.Text = Crystal.Journal;
            textBoxFormula.Text = Crystal.ChemicalFormulaSum;
            textBoxTitle.Text = Crystal.PublSectionTitle;

            textBoxDensity.Text = Crystal.Density.ToString("f5");
            numericalTextBoxVolume.Text = (Crystal.Volume * 1000).ToString("f5");
            textBoxZnumber.Text = Crystal.ChemicalFormulaZ.ToString();

            SymmetrySeriesNumber = Crystal.SymmetrySeriesNumber;//SymmetrySeriesNumberをフィールドからプロパティに変更。set{}の所でコンボボックスをセットする。(20170526)

            if (ChangeCellParameter)
            {
                numericBoxA.Value = Crystal.A * 10;
                numericBoxB.Value = Crystal.B * 10;
                numericBoxC.Value = Crystal.C * 10;
                numericBoxAlpha.RadianValue = Crystal.Alpha;
                numericBoxBeta.RadianValue = Crystal.Beta;
                numericBoxGamma.RadianValue = Crystal.Gamma;

                numericTextBoxAErr.Value = Crystal.A_err * 10;
                numericTextBoxBErr.Value = Crystal.B_err * 10;
                numericTextBoxCErr.Value = Crystal.C_err * 10;
                numericTextBoxAlphaErr.RadianValue = Crystal.Alpha_err;
                numericTextBoxBetaErr.RadianValue = Crystal.Beta_err;
                numericTextBoxGammaErr.RadianValue = Crystal.Gamma_err;
            }

            
            atomControl.Clear();
            atomControl.AddRange(Crystal.Atoms);

            
            //Bonds&Polyhedra中のコンボボックスの変更
            bondControl.ElementList = Crystal.Atoms.Select(a => a.ElementName).ToArray();

            //listBoxBondsAndPolyhedraにBondsを追加
            bondControl.Clear();
            bondControl.AddRange(Crystal.Bonds);


            //EOS関連
            skipEOSEvent = true;
            numericBoxPressure.Value = 0;
            numericBoxEOS_A.Value = crystal.EOSCondition.A;
            numericBoxEOS_B.Value = crystal.EOSCondition.B;
            numericBoxEOS_C.Value = crystal.EOSCondition.C;
            numericBoxEOS_V0perCell.Value = crystal.EOSCondition.CellVolume0;
            numericBoxEOS_Gamma0.Value = crystal.EOSCondition.Gamma0;
            numericBoxEOS_KT0.Value = crystal.EOSCondition.K0;
            numericBoxEOS_KperT.Value = crystal.EOSCondition.KperT;
            numericBoxEOS_KprimeT0.Value = crystal.EOSCondition.Kprime0;
            numericBoxEOS_Q.Value = crystal.EOSCondition.Q;
            numericBoxEOS_T0.Value = crystal.EOSCondition.T0;
            numericBoxEOS_Theta0.Value = crystal.EOSCondition.Theta0;
            checkBoxUseEOS.Checked = crystal.DoesUseEOS;
            radioButtonMieGruneisen.Checked = crystal.EOSCondition.ThermalPressureApproach == ThermalPressure.MieGruneisen;
            radioButtonTdependenceK0andV0.Checked = crystal.EOSCondition.ThermalPressureApproach == ThermalPressure.T_dependence_BM;
            radioButtonBirchMurnaghan.Checked = crystal.EOSCondition.IsothermalPressureApproach == IsothermalPressure.Birch_Murnaghan;
            radioButtonVinet.Checked = crystal.EOSCondition.IsothermalPressureApproach == IsothermalPressure.Vinet;
            textBoxEOS_Note.Text = crystal.EOSCondition.Note;
            numericalTextBoxTemperature.Value = crystal.EOSCondition.Temperature;
            skipEOSEvent = false;
            numericalTextBoxEOS_State_ValueChanged(new object(), new EventArgs());

            //弾性定数関連
            elasticityControl1.Stiffness = DenseMatrix.OfArray(crystal.ElasticStiffness);

            //PolyCrystallineProperty関連
            numericUpDownAngleResolution.Value = Math.Min((decimal)crystal.AngleResolution, numericUpDownAngleResolution.Maximum);
            numericUpDownAngleSubDivision.Value = (decimal)crystal.SubDivision;
            poleFigureControl.Crystal = crystal;

            SkipGenerateCrystal = false;
        }

        private void textBoxName_TextChanged(object sender, System.EventArgs e)
        {
            GenerateCrystal();
        }

        #region 空間群検索

        private void textBoxSearch_TextChanged(object sender, System.EventArgs e)
        {
            comboBoxSearchResult.Items.Clear();
            comboBoxSearchResult.Enabled = false;
            char[] c;
            if (textBoxSearch.Text.Length == 0)
                return;
            else
                c = textBoxSearch.Text.ToCharArray();
            Symmetry sym;
            int startIndex = 0;
            int index;
            for (int n = 0; n < SymmetryStatic.TotalSpaceGroupNumber; n++)
            {
                sym = SymmetryStatic.Get_Symmetry(n);
                startIndex = -1;
                for (int i = 0; i < c.Length; i++)
                {
                    index = sym.SpaceGroupHMStr.IndexOf(c[i], startIndex + 1);
                    if (index >= 0)
                        startIndex = index;
                    else
                    {
                        startIndex = -1;
                        break;
                    }
                }
                if (startIndex >= 0)
                    comboBoxSearchResult.Items.Add(sym.SpaceGroupHMStr);
            }
            if (comboBoxSearchResult.Items.Count > 0)
                comboBoxSearchResult.Enabled = true;
        }

        private void comboBoxSearchResult_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Symmetry sym = SymmetryStatic.Get_Symmetry(0);
            for (int n = 0; n <= SymmetryStatic.TotalSpaceGroupNumber; n++)
            {
                sym = SymmetryStatic.Get_Symmetry(n);
                if (comboBoxSearchResult.Text == sym.SpaceGroupHMStr)
                    break;
            }
            comboBoxCrystalSystem.Text = sym.CrystalSystemStr;
            comboBoxPointGroup.Text = sym.PointGroupHMStr;
            comboBoxSpaceGroup.Text = sym.SpaceGroupHMStr;
        }

        #endregion 空間群検索

        #region ドラッグドロップイベント

        public void FormCrystal_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileName.Length == 1)
            {
                try { Crystal = ConvertCrystalData.ConvertToCrystal(fileName[0]); }
                catch { return; }
            }
        }

        private void FormCrystal_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetData(DataFormats.FileDrop) != null) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        #endregion ドラッグドロップイベント

        private void numericalTextBoxUnitCell_ValueChanged(object sender, EventArgs e)
        {
            if (!(sender as NumericBox).ReadOnly)//自分が読み込み専用でなければ
                SetCellParameterReadOnlyStatus();
        }

      

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Crystal = new Crystal();
        }

        #region 右クリックメニュー

        private void importCrystalFromCIFAMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = " *.cif; *.amc | *.cif;*.amc";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Crystal = ConvertCrystalData.ConvertToCrystal(dlg.FileName);
                }
                catch { return; }
            }
        }

        public void exportThisCrystalAsCIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Crystal != null)
            {
                var dlg = new SaveFileDialog { Filter = " *.cif| *.cif" };
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(dlg.FileName, false);
                    string str = ConvertCrystalData.ConvertToCIF(Crystal);
                    sw.Write(str);
                    sw.Close();
                }
            }
        }

        private void scatteringFactorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formScatteringFactor.crystal == null)
                formScatteringFactor.crystal = Crystal;

            formScatteringFactor.Visible = !formScatteringFactor.Visible;
        }

        private void symmetryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formSymmetryInformation.crystal == null)
                formSymmetryInformation.crystal = Crystal;

            formSymmetryInformation.Visible = !formSymmetryInformation.Visible;
        }

        private void sendThisCrystalToOtherSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateCrystal();
            if (crystal != null)
                Clipboard.SetDataObject(Crystal2.GetCrystal2(crystal), true, 3, 10);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < crystal.Atoms.Length; i++)
                crystal.Atoms[i].Dsf = new DiffuseScatteringFactor(true, 0, 0, 0, 0, 0, 0, 0);
        }

        #endregion 右クリックメニュー

        private void CrystalControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.R)
                crystal.Reserved = !crystal.Reserved;
        }

        #region 空間群を表示するコンボボックスのオーナードロー関係

        private void comboBoxSpaceGroup_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            string txt = ((ComboBox)sender).Items[e.Index].ToString();

            //下付き文字用フォント
            Font sub = new Font("Times New Roman", 8f, FontStyle.Regular);
            //斜体
            Font italic = new Font("Times New Roman", 11f, FontStyle.Italic);
            //普通
            Font regular = new Font("Times New Roman", 11f, FontStyle.Regular);

            Font bold = new Font("Times New Roman", 10f, FontStyle.Bold);

            float xPos = e.Bounds.Left;
            Brush b = null;

            if ((e.State & DrawItemState.Selected) != DrawItemState.Selected)
                b = new SolidBrush(Color.Black);
            else
                b = new SolidBrush(Color.White);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //最初に数値を書く
            while (txt.Length > 0)
            {
                if (txt.StartsWith(" "))
                    xPos += 0;
                else if (txt.StartsWith("sub"))//subで始まる時は
                {
                    xPos -= 1;
                    txt = txt.Substring(3, txt.Length - 3);
                    e.Graphics.DrawString(txt[0].ToString(), sub, b, xPos, e.Bounds.Y + 3);
                    xPos += e.Graphics.MeasureString(txt[0].ToString(), sub).Width - 2;
                }
                else if (txt.StartsWith("-"))//-で始まる時は
                {
                    float x = e.Graphics.MeasureString(txt[1].ToString(), regular).Width;
                    e.Graphics.DrawLine(new Pen(b, 1), new PointF(xPos + 2f, e.Bounds.Y + 1), new PointF(x + xPos - 3f, e.Bounds.Y + 1));
                }
                else if (txt.StartsWith("Hex") || txt.StartsWith("Rho") || txt.StartsWith("(1)") || txt.StartsWith("(2)"))
                {
                    xPos += 2;
                    e.Graphics.DrawString(txt.Substring(0, 3), sub, b, xPos, e.Bounds.Y + 3);
                    xPos += e.Graphics.MeasureString(txt.Substring(0, 3), sub).Width - 2;
                    txt = txt.Substring(2);
                }
                else if (txt[0] == '/')
                {
                    xPos -= 1;
                    e.Graphics.DrawString(txt[0].ToString(), regular, b, xPos, e.Bounds.Y);
                    xPos += e.Graphics.MeasureString(txt[0].ToString(), regular).Width - 5;
                }
                else if (('0' <= txt[0] && '9' >= txt[0]) || txt[0] == '(' || txt[0] == ')')
                {
                    e.Graphics.DrawString(txt[0].ToString(), regular, b, xPos, e.Bounds.Y);
                    xPos += e.Graphics.MeasureString(txt[0].ToString(), regular).Width - 2;
                }
                else
                {
                    e.Graphics.DrawString(txt[0].ToString(), italic, b, xPos, e.Bounds.Y);
                    xPos += e.Graphics.MeasureString(txt[0].ToString(), italic).Width - 2;
                }
                txt = txt.Substring(1);
            }

            b.Dispose();
        }

        #endregion 空間群を表示するコンボボックスのオーナードロー関係

        #region EOSタブの入力設定

        private bool skipEOSEvent = false;

        private void numericalTextBoxEOS_State_ValueChanged(object sender, EventArgs e)
        {
            if (skipEOSEvent) return;

            if (numericalTextBoxEOS_V0perMol.ReadOnly && !double.IsNaN(numericBoxEOS_V0perCell.Value))
            {
                skipEOSEvent = true;
                numericalTextBoxEOS_V0perMol.Value = numericBoxEOS_V0perCell.Value * 6.0221367 / crystal.ChemicalFormulaZ / 10;
                skipEOSEvent = false;
            }
            GenerateCrystal();
            if (checkBoxUseEOS.Checked)
                numericBoxPressure.Value = crystal.EOSCondition.GetPressure(crystal.Volume * 1000);
        }

        private void numericalTextBoxEOS_V0perCell_Click2(object sender, EventArgs e)
        {
            numericBoxEOS_V0perCell.ReadOnly = false;
            numericalTextBoxEOS_V0perMol.ReadOnly = true;
        }

        private void numericalTextBoxEOS_V0perMol_Click2(object sender, EventArgs e)
        {
            numericBoxEOS_V0perCell.ReadOnly = true;
            numericalTextBoxEOS_V0perMol.ReadOnly = false;
        }

        private void numericalTextBoxEOS_V0perMol_ValueChanged(object sender, EventArgs e)
        {
            if (numericalTextBoxEOS_V0perMol.ReadOnly == false)
                numericBoxEOS_V0perCell.Value = numericalTextBoxEOS_V0perMol.Value / 6.0221367 * 10 * crystal.ChemicalFormulaZ;
        }

        #endregion EOSタブの入力設定

        private void CrystalControl_Resize(object sender, EventArgs e)
        {
            tabControl.Size = new Size(this.Size.Width, this.Size.Height - 30);
        }

        #region Polycrystalline関連

        private void buttonGenerateRandomOrientations_Click(object sender, EventArgs e)
        {
            if (this.Crystal.Crystallites == null)
                this.Crystal.SetCrystallites();
            /*
                           int[] index=new int[0];
                           double[] density=new double[0];
                           this.Crystal.Crystallites.GetBiasedDirection(Crystal.Crystallites.GetIndex(0,22,22,5), ref index, ref density, Math.PI / 180.0 * 0.1, 1);
                            //16040 2015/08ごろに辻野君に対してシミュレーションした番号

                           for (int i = 0; i < Crystal.Crystallites.Density.Length; i++)
                                     crystal.Crystallites.Density[i] = 0;

                               for (int i = 0; i < index.Length; i++)
                               Crystal.Crystallites.Density[index[i]] += density[i];
              */
            poleFigureControl.Crystal = Crystal;
        }

        public void DrawPoleFigure()
        {
            poleFigureControl.Draw(true);
        }

        #endregion Polycrystalline関連

        private void textBoxReferenfeChanged_TextChanged(object sender, EventArgs e)
        {
            GenerateCrystal();
        }

        private void numericUpDownAngleResolution_ValueChanged(object sender, EventArgs e)
        {
            GenerateCrystal();
        }

        #region poleFigureの右クリックメニュー
        /// <summary>
        /// poleFigureの右クリックメニュー　読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog { Filter = "Database File[*.cpo]|*.cpo" };
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    using (Stream stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        double version = (double)formatter.Deserialize(stream);
                        if (version == 1.0)
                        {
                            numericUpDownAngleResolution.Value = (decimal)((double)formatter.Deserialize(stream));
                            numericUpDownAngleSubDivision.Value = (decimal)((int)formatter.Deserialize(stream));
                            numericUpDownCrystallineSize.Value = (decimal)((double)formatter.Deserialize(stream));
                            double[] density = (double[])formatter.Deserialize(stream);
                            crystal.Crystallites = new Crystallite(Crystal, density);

                            poleFigureControl.Crystal = Crystal;
                        }
                    }
            }
            catch
            {
                MessageBox.Show("ファイルが読み込めません");
            }
        }

        /// <summary>
        /// poleFigureの右クリックメニュー　書き込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog            {                Filter = "Database File[*.cpo]|*.cpo"            };
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    using (Stream stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, 1.0);

                        formatter.Serialize(stream, crystal.AngleResolution);
                        formatter.Serialize(stream, crystal.SubDivision);
                        formatter.Serialize(stream, crystal.GrainSize);
                        formatter.Serialize(stream, crystal.Crystallites.Density);
                    }
            }
            catch
            {
                MessageBox.Show("ファイルが書き込みません");
            }
        }

        /// <summary>
        /// poleFigureの右クリックメニュー　ctfファイルで出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void asCTFFilecomatibleToCHANNEL5FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Export CTFボタンをクリックしたときの動作

            if (crystal.Crystallites == null) return;
            int maxCrystallites = 499900;

            var dlg = new SaveFileDialog            {                Filter = "*.ctf|*.ctf"            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var sw = new StreamWriter(dlg.FileName);
                sw.WriteLine("Channel Text File");
                sw.WriteLine("Prj\t OutPut from Recipro");
                sw.WriteLine("Author\t[Unknown]");
                sw.WriteLine("JobMode\tInteractive");
                sw.WriteLine("NoMeas\t" + maxCrystallites.ToString());//+ poleFigureControl1.PolyCrystal.Crysatallites.Length.ToString());
                sw.WriteLine("AcqE1\t0");
                sw.WriteLine("AcqE2\t0");
                sw.WriteLine("AcqE3\t0");
                sw.WriteLine("Euler angles refer to Sample Coordinate system (CS0)!\tMag\t0\tCoverage\t0\tDevice\t0\tKV\t0\tTiltAngle\t0\tTiltAxis\t0");
                sw.WriteLine("Phases\t1");
                sw.WriteLine("0.000;0.000;0.000\t90;90;90\t" + Crystal.Name + "\t3\t0\t3803863129_5.0.6.3\t1060505527\t[" + crystal.Name + "]");
                sw.WriteLine("Phase\tX\tY\tBands\tError\tEuler1\tEuler2\tEuler3\tMAD\tBC\tBS");

                double sum = 0;
                for (int i = 0; i < Crystal.Crystallites.TotalCrystalline; i++)
                    sum += crystal.Crystallites.Density[i] * crystal.Crystallites.SolidAngle[i];

                double tempSum = 0;
                int seed = 0;
                for (int i = 0; i < maxCrystallites; i++)
                {
                    double partialSum = (i + 0.5) / (double)maxCrystallites * sum;

                    while (tempSum + Crystal.Crystallites.Density[seed] * Crystal.Crystallites.SolidAngle[seed] < partialSum && seed < Crystal.Crystallites.Density.Length)
                    {
                        tempSum += Crystal.Crystallites.Density[seed] * Crystal.Crystallites.SolidAngle[seed];
                        seed++;
                    }

                    var euler1 = Euler.GetEulerAngle(Crystal.Crystallites.Rotations[seed]);
                    var euler = new double[] { euler1.Phi, euler1.Theta, euler1.Psi };
                    string str = "";
                    foreach (double angle in euler)
                    {
                        double d = (angle > 0 ? angle : angle + 2 * Math.PI) / Math.PI * 180;
                        if (d >= 100)
                            str += d.ToString("000.00") + "\t";
                        else if (d >= 10)
                            str += d.ToString("00.000") + "\t";
                        else
                            str += d.ToString("0.0000") + "\t";
                    }
                    sw.WriteLine("1\t0\t0\t0\t0\t" + str + "0\t0\t0");
                }
                sw.Close();
            }

            #endregion Export CTFボタンをクリックしたときの動作
        }

        /// <summary>
        /// poleFigureの右クリックメニュー　txtファイルで出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void asTXTFileAllEulerAngleAndDensityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (crystal.Crystallites == null) return;

            var dlg = new SaveFileDialog            {                Filter = "*.txt|*.txt"            };
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dlg.FileName))
                {
                    sw.WriteLine("Sample Name:\t" + Crystal.Name);
                    sw.WriteLine("Cell constants:\t"
                        + Crystal.A.ToString() + "\t" + Crystal.B.ToString() + "\t" + Crystal.C.ToString() + "\t"
                        + (crystal.Alpha / Math.PI * 180).ToString() + "\t" + (crystal.Beta / Math.PI * 180).ToString() + "\t" + (crystal.Gamma / Math.PI * 180).ToString());
                    sw.WriteLine("Space group:\t" + Crystal.Symmetry.SpaceGroupHMfullStr);
                    sw.WriteLine("");
                    sw.WriteLine("Euler angles refer to Sample Coordinate system");
                    sw.WriteLine("No.\tEuler1\tEuler2\tEuler3\tDensity");

                    double sum = 0;

                    double[] density = new double[Crystal.Crystallites.TotalCrystalline];
                    int[] index = new int[Crystal.Crystallites.TotalCrystalline];
                    for (int i = 0; i < Crystal.Crystallites.TotalCrystalline; i++)
                    {
                        density[i] = crystal.Crystallites.Density[i] * crystal.Crystallites.SolidAngle[i];
                        index[i] = i;
                        sum += density[i];
                    }
                    if (sender == asTXTFileallEulerAngleAndDensitySortedToolStripMenuItem)
                    {
                        Array.Sort(density, index);
                        density = density.Reverse().ToArray();
                        index = index.Reverse().ToArray();
                    }

                    for (int i = 0; i < Crystal.Crystallites.TotalCrystalline; i++)
                    {
                        string str = i.ToString() + "\t";
                        var euler1 = Euler.GetEulerAngle(Crystal.Crystallites.Rotations[index[i]]);
                        var euler = new double[] { euler1.Phi, euler1.Theta, euler1.Psi };

                        foreach (double angle in euler)
                        {
                            double d = (angle > 0 ? angle : angle + 2 * Math.PI) / Math.PI * 180;
                            str += d.ToString("000.0000") + "\t";
                        }
                        str += (density[i] / sum * crystal.Crystallites.TotalCrystalline).ToString();
                        sw.WriteLine(str);
                    }
                }
            }
        }

        #endregion

        private void revertCellConstantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crystal.RevertInitialCellConstants();
            Crystal = crystal;
        }

        private void strainControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formStrain.crystal == null)
                formStrain.crystal = Crystal;

            formStrain.Visible = !formStrain.Visible;
        }

        private void elasticityControl1_ValueChanged(object sender, EventArgs e)
        {
            if (elasticityControl1.Mode == Elasticity.Mode.Compliance)
                formStrain.Compliance = elasticityControl1.Compliance;
            else
                formStrain.Stiffness = elasticityControl1.Stiffness;

            formStrain.ElasticityMode = elasticityControl1.Mode;
        }

        private void atomControl_AtomsChanged(object sender, EventArgs e)
        {
            GenerateCrystal();
        }
    }
}
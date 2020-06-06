﻿using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Crystallography.Controls
{
    public partial class SymmetryControl : UserControl
    {
        #region プロパティ、フィールド、イベントハンドラ

        public bool SkipEvent { get; set; } = false;
        public int CrystalSystemIndex => comboBoxCrystalSystem.SelectedIndex;
        public int PointGroupIndex => comboBoxPointGroup.SelectedIndex;
        public int SpaceGroupIndex => comboBoxSpaceGroup.SelectedIndex;


        public int SymmetrySeriesNumber
        {
            get => (CrystalSystemIndex >= 0 && PointGroupIndex >= 0 && SpaceGroupIndex >= 0) ?
                    SymmetryStatic.BelongingNumberOfSymmetry[CrystalSystemIndex][PointGroupIndex][SpaceGroupIndex] : 0;
            set
            {
                if (value >= 0 && value <= SymmetryStatic.TotalSpaceGroupNumber)
                {
                    (int CrystalSystem, int PointGroup, int SpaceGroup) = SymmetryStatic.GetSytemAndGroupFromSeriesNumber(value);
                    SkipEvent = true;

                    comboBoxCrystalSystem.SelectedIndex = CrystalSystem;

                    comboBoxPointGroup.Items.Clear();
                    comboBoxPointGroup.Items.AddRange(PointGroupArray(CrystalSystem));
                    comboBoxPointGroup.SelectedIndex = PointGroup;

                    comboBoxSpaceGroup.Items.Clear();
                    comboBoxSpaceGroup.Items.AddRange(SpaceGroupArray(CrystalSystem, PointGroup));
                    comboBoxSpaceGroup.SelectedIndex = SpaceGroup;

                    SkipEvent = false;

                    SetCellConstantsBySymmetry();
                }
            }
        }

        /// <summary>
        /// Cell constants の get/set. 単位はnm, radian.
        /// </summary>
        public (double A, double B, double C, double Alpha, double Beta, double Gamma) CellConstants
        {
            get => (numericBoxA.Value /10, numericBoxB.Value / 10, numericBoxC.Value / 10, numericBoxAlpha.RadianValue, numericBoxBeta.RadianValue,numericBoxGamma.RadianValue);
            set
            {
                SkipEvent = true;
                numericBoxA.Value = value.A * 10;
                numericBoxB.Value = value.B * 10;
                numericBoxC.Value = value.C * 10;
                numericBoxAlpha.RadianValue = value.Alpha;
                numericBoxBeta.RadianValue = value.Beta;
                numericBoxGamma.RadianValue = value.Gamma;
                SkipEvent = false;
            }
        }

        /// <summary>
        /// Cell constants error の get/set. 単位はnm, radian.
        /// </summary>
        public (double AErr, double BErr, double CErr, double AlphaErr, double BetaErr, double GammaErr) CellConstantsErr
        {
            get => (numericBoxAErr.Value / 10, numericBoxBErr.Value / 10, numericBoxCErr.Value / 10,
                numericBoxAlphaErr.RadianValue, numericBoxBetaErr.RadianValue, numericBoxGammaErr.RadianValue);
            set
            {
                numericBoxAErr.Value = value.AErr * 10;
                numericBoxBErr.Value = value.BErr * 10;
                numericBoxCErr.Value = value.CErr * 10;
                numericBoxAlphaErr.RadianValue = value.AlphaErr;
                numericBoxBetaErr.RadianValue = value.BetaErr;
                numericBoxGammaErr.RadianValue = value.GammaErr;
            }
        }

        public bool ShowError
        {
            get => checkBoxShowError.Checked;
            set
            {
                SkipEvent = true;
                checkBoxShowError.Checked = value;
                SkipEvent = false;
                tableLayoutPanel1.ColumnStyles[2].Width = tableLayoutPanel1.ColumnStyles[6].Width = checkBoxShowError.Checked ? 25 : 0;
            }
        }

        public event EventHandler ItemChanged;

        #endregion

        #region コンストラクタ

        public SymmetryControl()
        {
            InitializeComponent();
            SymmetrySeriesNumber = 0;
            tableLayoutPanel1.ColumnStyles[2].Width = tableLayoutPanel1.ColumnStyles[6].Width= 0;
        }

        #endregion

        #region 空間群検索　関連
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            comboBoxSearchResult.Items.Clear();
            comboBoxSearchResult.Enabled = false;
            char[] c;
            if (textBoxSearch.Text.Length == 0)
                return;
            else
                c = textBoxSearch.Text.ToCharArray();
            for (int n = 0; n < SymmetryStatic.TotalSpaceGroupNumber; n++)
            {
                var sym = SymmetryStatic.Get_Symmetry(n);
                var startIndex = -1;
                for (int i = 0; i < c.Length; i++)
                {
                    var index = sym.SpaceGroupHMStr.IndexOf(c[i], startIndex + 1);
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

        private void comboBoxSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sym = Enumerable.Range(0, SymmetryStatic.TotalSpaceGroupNumber)
                .Select(n => SymmetryStatic.Get_Symmetry(n))
                .First(sym => sym.SpaceGroupHMStr == comboBoxSearchResult.Text);

            comboBoxCrystalSystem.Text = sym.CrystalSystemStr;
            comboBoxPointGroup.Text = sym.PointGroupHMStr;
            comboBoxSpaceGroup.Text = sym.SpaceGroupHMStr;
        }

        #endregion

        #region 対称性コンボボックスのイベント

        private void comboBoxCrystalSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SkipEvent) return;

            SkipEvent = true;
            comboBoxPointGroup.Items.Clear();
            comboBoxSpaceGroup.Items.Clear();
            comboBoxPointGroup.Items.AddRange(PointGroupArray(CrystalSystemIndex));
            SkipEvent = false;

            comboBoxPointGroup.SelectedIndex = 0;
        }

        private string[] PointGroupArray(int crystalSystemIndex)
        => SymmetryStatic.BelongingNumberOfSymmetry[crystalSystemIndex]
                .Select(n => SymmetryStatic.Get_Symmetry(n[0]).PointGroupHMStr).Distinct().ToArray();
            

        private void comboBoxPointGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SkipEvent) return;
            
            SkipEvent = true;
            comboBoxSpaceGroup.Items.Clear();
            comboBoxSpaceGroup.Items.AddRange(SpaceGroupArray(CrystalSystemIndex, PointGroupIndex));
            SkipEvent = false;

            comboBoxSpaceGroup.SelectedIndex = 0;
        }

        private string[] SpaceGroupArray(int crystalSystemIndex, int pointGroupIndex)
        => SymmetryStatic.BelongingNumberOfSymmetry[crystalSystemIndex][pointGroupIndex]
                .Select(n => SymmetryStatic.Get_Symmetry(n).SpaceGroupHMStr).ToArray();


        private void comboBoxSpaceGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SkipEvent) return;
            SetCellConstantsBySymmetry();
        }

        #endregion

        #region 空間群が変化したとき、あるいは格子定数が変化したとき呼ばれる. 対称性の制限下で格子定数を再設定
        private void SetCellConstantsBySymmetry()
        {
            if (SkipEvent) return;
            SkipEvent = true;

            var tempSym = SymmetryStatic.Get_Symmetry(SymmetrySeriesNumber);
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
                            numericBoxBetaErr.Value = numericBoxGammaErr.Value = 0;
                            break;

                        case "b":
                            numericBoxBeta.Enabled = true;
                            numericBoxAlpha.Enabled = numericBoxGamma.Enabled = false;
                            numericBoxAlpha.Value = numericBoxGamma.Value = 90;
                            numericBoxAlphaErr.Value = numericBoxGammaErr.Value = 0;

                            break;

                        case "c":
                            numericBoxGamma.Enabled = true;
                            numericBoxAlpha.Enabled = numericBoxBeta.Enabled = false;
                            numericBoxAlpha.Value = numericBoxBeta.Value = 90;
                            numericBoxAlphaErr.Value = numericBoxBetaErr.Value = 0;
                            break;
                    }
                    break;

                case "orthorhombic":
                    numericBoxA.Enabled = numericBoxB.Enabled = numericBoxC.Enabled = true;
                    numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                    numericBoxAlpha.Value = numericBoxBeta.Value = numericBoxGamma.Value = 90;
                    numericBoxAlphaErr.Value = numericBoxBetaErr.Value = numericBoxGammaErr.Value = 0;

                    break;

                case "tetragonal":
                    numericBoxA.Enabled = numericBoxC.Enabled = true;
                    numericBoxB.Enabled = false;
                    numericBoxB.Value = numericBoxA.Value;
                    numericBoxBErr.Value = numericBoxAErr.Value;
                    numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                    numericBoxAlpha.Value = numericBoxBeta.Value = numericBoxGamma.Value = 90;
                    numericBoxAlphaErr.Value = numericBoxBetaErr.Value = numericBoxGammaErr.Value = 0;
                    break;

                case "trigonal":
                    switch (tempSym.SpaceGroupHMStr.IndexOf("Rho") >= 0 && tempSym.SpaceGroupHMStr.IndexOf("R") >= 0)
                    {
                        case false:
                            numericBoxA.Enabled = numericBoxC.Enabled = true;
                            numericBoxB.Enabled = false;
                            numericBoxB.Value = numericBoxA.Value;
                            numericBoxBErr.Value = numericBoxAErr.Value;
                            numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                            numericBoxAlpha.Value = numericBoxBeta.Value = 90; numericBoxGamma.Value = 120;
                            numericBoxAlphaErr.Value = numericBoxBetaErr.Value = numericBoxGammaErr.Value = 0;
                            break;

                        case true:
                            numericBoxA.Enabled = true;
                            numericBoxB.Enabled = numericBoxC.Enabled = false;
                            numericBoxC.Value = numericBoxB.Value = numericBoxA.Value;
                            numericBoxCErr.Value = numericBoxBErr.Value = numericBoxAErr.Value;

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
                    numericBoxBErr.Value = numericBoxAErr.Value;
                    numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                    numericBoxAlpha.Value = numericBoxBeta.Value = 90; numericBoxGamma.Value = 120;
                    numericBoxAlphaErr.Value = numericBoxBetaErr.Value = numericBoxGammaErr.Value = 0;
                    break;

                case "cubic":
                    numericBoxA.Enabled = true;
                    numericBoxB.Enabled = numericBoxC.Enabled = false;
                    numericBoxC.Value = numericBoxB.Value = numericBoxA.Value;
                    numericBoxCErr.Value = numericBoxBErr.Value = numericBoxAErr.Value;
                    numericBoxAlpha.Enabled = numericBoxBeta.Enabled = numericBoxGamma.Enabled = false;
                    numericBoxAlpha.Value = numericBoxBeta.Value = numericBoxGamma.Value = 90;
                    numericBoxAlphaErr.Value = numericBoxBetaErr.Value = numericBoxGammaErr.Value = 0;
                    break;
            }
            numericBoxAErr.Enabled = numericBoxA.Enabled;
            numericBoxBErr.Enabled = numericBoxB.Enabled;
            numericBoxCErr.Enabled = numericBoxC.Enabled;
            numericBoxAlphaErr.Enabled = numericBoxAlpha.Enabled;
            numericBoxBetaErr.Enabled = numericBoxBeta.Enabled;
            numericBoxGammaErr.Enabled = numericBoxGamma.Enabled;

            SkipEvent = false;

            ItemChanged?.Invoke(this, new EventArgs());
            //GenerateFromInterface();
        } 
        #endregion

        #region 群の記号を斜体、上付き、下付などに整形する

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
        #endregion

        #region 格子定数変化
        private void numericBoxCellConstants_ValueChanged(object sender, EventArgs e)
        {
            if (SkipEvent) return;
            if (!(sender as NumericBox).ReadOnly)//自分が読み込み専用でなければ
                SetCellConstantsBySymmetry();
        }

        #endregion

        #region エラー表示/非表示
        private void checkBoxShowError_CheckedChanged(object sender, EventArgs e)
        {
            if (SkipEvent) 
                return;
            ShowError = checkBoxShowError.Checked;
        }
        #endregion
    }
}

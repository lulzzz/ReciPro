﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crystallography;

namespace Crystallography.Controls
{
    public partial class BondInputControl : UserControl
    {
        #region プロパティ, フィールド、イベントハンドラ
        public Crystal Crystal { get; set; } = null;
        public bool SkipEvent { get; set; } = false;

        private string[] elementList = new string[0];
        public string[] ElementList
        {
            get => elementList;
            set
            {
                elementList = value;
                if (elementList != null)
                {
                    comboBoxBondingAtom1.Items.Clear();
                    comboBoxBondingAtom2.Items.Clear();
                    foreach (var e in elementList)
                        if (!comboBoxBondingAtom1.Items.Contains(e))
                        {
                            comboBoxBondingAtom1.Items.Add(e);
                            comboBoxBondingAtom2.Items.Add(e);
                        }
                }
            }
        }

        private DataSet.DataTableBondDataTable table;

        public event EventHandler ItemsChanged;
        #endregion,


        public BondInputControl()
        {
            InitializeComponent();
            table = dataSet.DataTableBond;
        }

        #region Bondsクラスを画面下部　から生成 /　にセット
        public Bonds GetFromInterface()
        {
            if (ElementList.Length < 1 || comboBoxBondingAtom1.Text == "" || comboBoxBondingAtom2.Text == "")
                return null;
            else
                return new Bonds(
                    true, ElementList, comboBoxBondingAtom1.Text, comboBoxBondingAtom2.Text,
                    numericBoxBondMinLength.Value, numericBoxBondMaxLength.Value,
                    numericBoxBondRadius.Value, numericBoxBondAlpha.Value,
                    colorControlBond.Color, numericBoxPolyhedronAlpha.Value,
                    checkBoxShowPolyhedron.Checked, checkBoxShowCenterAtom.Checked, checkBoxShowVertexAtoms.Checked,
                    checkBoxShowInnerBonds.Checked, colorControlPlyhedron.Color, checkBoxShowEdges.Checked,
                    numericBoxEdgeWidth.Value, colorControlEdges.Color);
        }

        public void SetToInterface(Bonds b)
        {
            ElementList = b.ElementList;

            comboBoxBondingAtom1.Text = b.Element1;
            comboBoxBondingAtom2.Text = b.Element2;
            numericBoxBondMinLength.Value = b.MinLength;
            numericBoxBondMaxLength.Value = b.MaxLength;
            numericBoxBondRadius.Value = b.Radius;
            numericBoxBondAlpha.Value = b.BondTransParency;
            colorControlBond.Color = Color.FromArgb(b.ArgbBond);
            numericBoxPolyhedronAlpha.Value = b.PolyhedronTransParency;

            checkBoxShowPolyhedron.Checked = b.ShowPolyhedron;
            checkBoxShowCenterAtom.Checked = b.ShowCenterAtom;
            checkBoxShowVertexAtoms.Checked = b.ShowVertexAtom;
            checkBoxShowInnerBonds.Checked = b.ShowInnerBonds;
            colorControlPlyhedron.Color = Color.FromArgb(b.ArgbPolyhedron);

            checkBoxShowEdges.Checked = b.ShowEdges;
            numericBoxEdgeWidth.Value = b.EdgeLineWidth;
            colorControlEdges.Color = Color.FromArgb(b.ArgbEdge);
        }
        #endregion

        #region チェックボックスイベント

        private void checkBoxShowPolyhedron_CheckedChanged(object sender, EventArgs e) => groupBoxPolyhedron.Enabled = checkBoxShowPolyhedron.Checked;
        private void checkBoxShowEdges_CheckedChanged(object sender, EventArgs e) => groupBoxEdge.Enabled = checkBoxShowEdges.Checked;


        #endregion

        #region データベース操作
        /// <summary>
        /// データベースにbondsを追加する
        /// </summary>
        /// <param name="bonds"></param>
        public void Add(Bonds bonds)
        {
            if (bonds != null)
                table.Add(bonds);

            ItemsChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// データベースに原子を追加する
        /// </summary>
        /// <param name="bonds"></param>
        public void AddRange(IEnumerable<Bonds> bonds)
        {
            if (bonds != null)
            {
                foreach (var b in bonds)
                    table.Add(b);
                ItemsChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// データベースのi番目の原子を削除
        /// </summary>
        /// <param name="i"></param>
        public void Delete(int i)
        {
            table.Remove(i);
            ItemsChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// データベースのi番目の原子を置換
        /// </summary>
        /// <param name="bonds"></param>
        /// <param name="i"></param>
        public void Replace(Bonds bonds, int i)
        {
            table.Replace(bonds, i);
            ItemsChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// データベースの原子を全て削除する
        /// </summary>
        public void Clear()
        {
            table.Clear();
            ItemsChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// データベース中の全ての原子を取得
        /// </summary>
        /// <returns></returns>
        public Bonds[] GetAll() => table.GetAll();

        #endregion

        #region 追加/削除/置換 ボタン

        /// <summary>
        /// 追加ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            var bond = GetFromInterface();
            if (bond != null)
            {
                Add(bond);
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        /// <summary>
        /// 変更ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, System.EventArgs e)
        {
            var pos = bindingSource.Position;
            if (pos >= 0)
            {
                Replace(GetFromInterface(), pos);
                bindingSource.Position = pos;
            }
        }

        /// <summary>
        /// 削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, System.EventArgs e)
        {
            int pos = bindingSource.Position;
            if (pos >= 0)
            {
                SkipEvent = true;//bindingSourceAtoms_PositionChangedが呼ばれるのを防ぐ
                Delete(pos);
                SkipEvent = false;
                bindingSource.Position = bindingSource.Count > pos ? pos : pos - 1;//選択列を選択しなおす
            }
        }

        #endregion

        #region bindingSourceイベント

        /// <summary>
        /// 選択行が変更されたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingSource_PositionChanged(object sender, System.EventArgs e)
        {
            if (SkipEvent) return;

            if (bindingSource.Position >= 0 && bindingSource.Count > 0)
                SetToInterface(dataSet.DataTableBond.Get(bindingSource.Position));
        }
        #endregion

        #region dataGridView イベント

        private void dataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {//チェックボックスが変わると即座に反映させる
            if (dataGridView.CurrentCellAddress.X == 0 && dataGridView.IsCurrentCellDirty)
                dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);//コミットする
        }
        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                table.Get(bindingSource.Position).Enabled =
                    (bool)dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                ItemsChanged?.Invoke(this, new EventArgs());
            }
        } 
        #endregion

    }
}
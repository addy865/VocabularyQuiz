using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabularyQuiz
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private int curr_x;
        private int curr_y;
        private bool isWndMove;

        private void List_Load(object sender, EventArgs e)
        {
            GetList("", false);
        }

        private void GetList(string sKeyValue, bool bSearch)
        {
            LVData.Items.Clear();

            string sConditionKey = string.Empty;
            if (bSearch)
                sConditionKey = string.IsNullOrEmpty(sKeyValue) ? "" : $"where word_eng like '{sKeyValue}%'";

            string sSQL = $"select row_number() over(order by word_eng) as rowidx, a.word_eng, a.word_tra, a.remark from sys_word a {sConditionKey}";
            DataSet dsTemp = Main.ExecuteSQL(sSQL);

            //Add list.
            ListViewItem[] LVItem = new ListViewItem[dsTemp.Tables[0].Rows.Count];
            for (int i = 0; i < dsTemp.Tables[0].Rows.Count; i++)
            {
                string sNum = dsTemp.Tables[0].Rows[i][0].ToString() ?? "";
                string sTraWord = dsTemp.Tables[0].Rows[i][1].ToString() ?? "";
                string sEngWord = dsTemp.Tables[0].Rows[i][2].ToString() ?? "";
                string sRemark = dsTemp.Tables[0].Rows[i][3].ToString() ?? "";

                LVItem[i] = new ListViewItem(new String[] { sNum, sTraWord, sEngWord, sRemark });
            }
            LVData.Items.AddRange(LVItem);
            LVData.Focus();

            //Select key row.
            if (!string.IsNullOrEmpty(sKeyValue))
            {
                ListViewItem LVItemKey = LVData.FindItemWithText(sKeyValue);
                if (LVItemKey != null)
                    LVItemKey.Selected = true;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            #region Check data

            if (string.IsNullOrEmpty(EditEng.Texts.Trim()))
            {
                MessageBox.Show($"English is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EditEng.Focus();
                return;
            }

            if (string.IsNullOrEmpty(EditTra.Texts.Trim()))
            {
                MessageBox.Show($"Chinese is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EditTra.Focus();
                return;
            }

            string sSQL = $"select 1 from sys_word where word_eng = '{EditEng.Texts.Trim()}'";
            DataSet dsTemp = Main.ExecuteSQL(sSQL);
            if (dsTemp.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show($"{EditEng.Text} already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EditEng.Focus();
                return;
            }

            #endregion

            sSQL = $@"INSERT INTO SYS_WORD VALUES ('{EditEng.Texts.Trim()}', '{EditTra.Texts.Trim()}', '{EditRemark.Texts.Trim()}')";
            Main.ExecuteSQL(sSQL);

            GetList(EditEng.Text.Trim() , false);

            EditEng.Texts = String.Empty;
            EditTra.Texts = String.Empty;
            EditRemark.Texts = String.Empty;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVData.SelectedItems.Count == 0)
                return;

            string sValue = LVData.SelectedItems[0].SubItems[1].Text.ToString();
            DialogResult dialog = MessageBox.Show($"Remove {sValue} ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialog == DialogResult.Yes)
            {
                string sSQL = $"delete from sys_word where word_eng = '{sValue}'";
                Main.ExecuteSQL(sSQL);

                //Refresh list
                GetList("", false);
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVData.SelectedItems.Count == 0)
                return;

            string sKey = LVData.SelectedItems[0].SubItems[1].Text.ToString();

            Modify FormModify = new();
            FormModify.EditEng.Text = sKey;
            FormModify.EditTra.Text = LVData.SelectedItems[0].SubItems[2].Text.ToString();
            FormModify.EditRemark.Text = LVData.SelectedItems[0].SubItems[3].Text.ToString();

            if (FormModify.ShowDialog() == DialogResult.OK)
            {
                string sSQL = @$"update sys_word 
                                 set word_eng = '{FormModify.EditEng.Text.Trim()}'
                                   , word_tra = '{FormModify.EditTra.Text.Trim()}'
                                   , remark = '{FormModify.EditRemark.Text.Trim()}'
                                 where word_eng = '{sKey}'";
                Main.ExecuteSQL(sSQL);

                //Refresh list
                GetList(FormModify.EditEng.Text.Trim(), false);
            }
        }

        private void EditSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            GetList(EditSearch.Texts.Trim(), true);
            EditSearch.Focus();
        }

        private void BtnTitleBar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Tag.ToString())
            {
                case "Close":
                    this.Close();
                    break;

                case "Size":
                    if (WindowState == FormWindowState.Normal)
                        this.WindowState = FormWindowState.Maximized;
                    else
                        this.WindowState = FormWindowState.Normal;
                    break;

                case "Minimize":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        #region Title Bar move function 

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.curr_x = e.X;
                this.curr_y = e.Y;
                this.isWndMove = true;
            }
        }

        private void PanelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isWndMove)
                this.Location = new Point(this.Left + e.X - this.curr_x, this.Top + e.Y - this.curr_y);
        }

        private void PanelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            this.isWndMove = false;
        }

        #endregion

       
    }
}

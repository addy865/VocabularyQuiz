using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Reflection;

namespace VocabularyQuiz
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static string SDBPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "SDB.db");
        private int curr_x;
        private int curr_y;
        private bool isWndMove;
        private int iTopicNum = 0;
        private int iCorrect = 0;
        private int iAnswerQty = 0;
        private DataSet dsBase;

        private void Main_Load(object sender, EventArgs e)
        {
            InitailForm();
        }

        private void InitailForm()
        {
            TSLabelVersion.Text = $" Version {FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion}";
            CombType.SelectedIndex = 0;

            GetWordBase(true);
        }

        private void GetWordBase(bool isInitail)
        {
            dsBase = new DataSet();
            string sSQL = "select a.word_tra, a.word_eng, row_number() over(order by word_eng) as rowidx from sys_word a";
            dsBase = ExecuteSQL(sSQL);

            if (dsBase.Tables[0].Rows.Count == 0)
                MessageBox.Show("Vocabulary not setup.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            iCorrect = 0;
            iAnswerQty = 0;
            NumQty.Maximum = dsBase.Tables[0].Rows.Count;
            
            if (isInitail)
                NumQty.Value = dsBase.Tables[0].Rows.Count;
            else
                NumQty.Enabled = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            GetWordBase(false);
            GetTopic();
        }

        private void GetTopic()
        {
            if(dsBase.Tables[0].Rows.Count == 0)
                ShowEndMessage();

            Random rn = new Random();
            iTopicNum = rn.Next(0, dsBase.Tables[0].Rows.Count);
            EditTopic.Texts = dsBase.Tables[0].Rows[iTopicNum][CombType.SelectedIndex].ToString();
        }        

        private void EditAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CheckAnswer();
                GetTopic();
                EditAnser.Texts = string.Empty;
                EditAnser.Focus();

                if (++iAnswerQty == NumQty.Value) 
                    ShowEndMessage();
            }
        }
        private void ShowEndMessage()
        {
            string sMessage = $"Complete. ({iCorrect}/{NumQty.Value}){Environment.NewLine}Start again ?";
            DialogResult dialog = MessageBox.Show(sMessage, "End", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                GetWordBase(false);
                GetTopic();
            }
            else
            {
                NumQty.Enabled = true;
            }
            return;
        }

        private void CheckAnswer()
        {
            int idxAns = CombType.SelectedIndex == 0 ? 1 : 0;
            string sAns = dsBase.Tables[0].Rows[iTopicNum][idxAns].ToString();

            if(sAns.ToUpper() != EditAnser.Texts.ToUpper())
            {
                LabMsg.ForeColor = Color.Red;
                LabMsg.Text = $"{sAns}";
            }
            else
            {
                LabMsg.ForeColor = Color.Green;
                LabMsg.Text = $"Correct";
                iCorrect++;
            }

            //Remove this topic
            DataRow row = dsBase.Tables[0].Rows[iTopicNum];
            dsBase.Tables[0].Rows.Remove(row);
        }

        private void VocabularyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List FormList = new();
            FormList.ShowDialog();
            InitailForm();
        }

        public static DataSet ExecuteSQL(string sSQL)
        {

            DataSet ds = new DataSet();
            SQLiteConnection con = new SQLiteConnection($"data source = {SDBPath}");
            try
            {
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = con;
                cmd.CommandText = sSQL;

                var vDataAdapter = new SQLiteDataAdapter(sSQL, con);
                vDataAdapter.Fill(ds);

                if (con.State == ConnectionState.Open) con.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ExecuteSQL: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds;
            }
        }

        private void BtnTitleBar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
                        
            switch(btn.Tag.ToString())
            {
                case "Close":
                    Application.Exit();
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
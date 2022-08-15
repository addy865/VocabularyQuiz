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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EditEng.Text)) 
            {
                MessageBox.Show($"English is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EditEng.Focus();
                return;
            }
            if(string.IsNullOrEmpty(EditTra.Text))
            {
                MessageBox.Show($"Chinese is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EditTra.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}

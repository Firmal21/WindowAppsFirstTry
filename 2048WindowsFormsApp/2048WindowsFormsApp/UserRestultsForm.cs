using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class UserRestultsForm : Form
    {
        public UserRestultsForm()
        {
            InitializeComponent();
        }

        private void UserRestultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResults.GetUserResults();
            
            foreach (var result in results)
            {
                userResultsDataGridView.Rows.Add(result.Name, result.Score);
            }

        }

        

        private void restartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class WelcomeForm : Form
    {
        public static string UserName { get; set; }
        public static int MapSize { get; set; }
        public WelcomeForm()
        {
            InitializeComponent();
        }

        public void WelcomeForm_Load(object sender, EventArgs e)
        {
        }

        public void nextButton_Click(object sender, EventArgs e)
        {
            SelectMapSize();
            UserName = nameTextBox.Text;
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();

        }

        public void SelectMapSize()
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            var mapSize = (selectedState.Substring(2));
            MapSize = Int32.Parse(mapSize);
        }
    }
}

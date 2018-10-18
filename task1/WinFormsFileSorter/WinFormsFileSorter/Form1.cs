using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFileSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.labelLoadFile.Text = openFileDialog.FileName;
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (this.textBoxSortName.Text == String.Empty)
                this.textBoxSortName.Text = "Default.txt";
            try
            {
                FileSorter.sortFile(this.labelLoadFile.Text, this.textBoxSortName.Text);
                MessageBox.Show("Sorted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

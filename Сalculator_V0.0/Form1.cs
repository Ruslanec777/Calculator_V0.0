using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator_V0._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NubButClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                textBoxResult.Text += button.Text;
            }

            if (textBoxResult.Text.Length>1&& textBoxResult.Text[0]=='0')
            {
                textBoxResult.Text.Remove(0);
            }


        }

        private void butSign_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text[0] == '-')
            {
                textBoxResult.Text= textBoxResult.Text.Remove(0, 1);
            }
            else
            {
                textBoxResult.Text= textBoxResult.Text.Insert(0, "-");
            }
        }
    }
}

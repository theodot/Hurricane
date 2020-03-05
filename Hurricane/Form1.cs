using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //get inputs
            string category = categoryInput.Text;

            //process the input
            switch (category)
            {
                case "1":
                    outputLabel.Text = "119-153 km/hr";
                    break;
                case "2":
                    outputLabel.Text = "154-177 km/hr";
                    break;
                case "3":
                    outputLabel.Text = "178-209 km/hr";
                    break;
                case "4":
                    outputLabel.Text = "210-249 km/hr";
                    break;
                case "5":
                    outputLabel.Text = "greater than 249 km/hr";
                    break;
                default:
                    outputLabel.Text = "That's not a valid category";
                    break;
            }
        }
    }
}

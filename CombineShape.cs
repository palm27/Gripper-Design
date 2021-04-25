using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Gripper_Design
{
    public partial class CombineShape : UserControl
    {
        int Mass_1 = 0;
        public CombineShape()
        {
            InitializeComponent();
        }

        private void CombineShape_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
        public int Mass_value
        {
            get
            {
                System.Diagnostics.Debug.WriteLine("Mass_1: {0}", Mass_1);
                return this.Mass_1;
            }
            set
            {
                this.Mass_1 = value;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                Mass_1 = int.Parse(textBox1.Text);
            }
        }
       
    }
}

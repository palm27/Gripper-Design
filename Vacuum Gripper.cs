using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Gripper_Design
{
    public partial class Vacuum_Gripper : UserControl
    {
        int Mass_1 = 0, D1 = 0, Press1 = 0;
        public Vacuum_Gripper()
        {
            InitializeComponent();
           
        }
        public ComboBox Surfaceform
        {
            get
            {
                return this.Surface_comboBox;
            }
            set
            {
                this.Surface_comboBox = value;
            }
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

        public int Number_of_SuctionCup
          {
              get
              {
                System.Diagnostics.Debug.WriteLine("Send_Number: {0}", D1);
                return this.D1;
              }
              set
              {
                  this.D1 = value;
              }
          }

        public int Pressure_value
        {
            get
            {
                return this.Press1;
            }
            set
            {
                this.Press1 = value;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                D1 = int.Parse(textBox2.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                Press1 = int.Parse(textBox3.Text);
            }
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                Mass_1 = int.Parse(textBox1.Text);
                
            }
        }

    }
}

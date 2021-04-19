using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Gripper_Design
{
    public partial class GripperSelection : UserControl
    {
        public int Gripper_index = 4;
        public GripperSelection()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gripper_index = comboBox1.SelectedIndex;
        }
    }
}

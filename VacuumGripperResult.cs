using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Gripper_Design
{
    public partial class VacuumGripperResult : UserControl
    {
        public VacuumGripperResult()
        {
            InitializeComponent();
        }
        // Change cup number
        public Label Cupnumber
        {
          get 
            { 
                return this.label3; 
            }
          set
            { 
                this.label3 = value; 
            }
        }
        public Label Cuptype
        {
            get
            {
                return this.label5;
            }
            set
            {
                this.label5 = value;
            }
        }
        public Label CupDiameter
        {
            get
            {
                return this.label7;
            }
            set
            {
                this.label7 = value;
            }
        }
        private void VacuumGripperResult_Load(object sender, EventArgs e)
        {

        }
    }
}

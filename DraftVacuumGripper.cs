using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Gripper_Design
{
    public partial class DraftVacuumGripper : UserControl
    {
        public DraftVacuumGripper()
        {
            InitializeComponent();
        }
        public Label NumberOfCup
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
        public Label NumberOfVacuum
        {
            get
            {
                return this.label11;
            }
            set
            {
                this.label11 = value;
            }
        }
        public Label PadDiameter
        {
            get
            {
                return this.label9;
            }
            set
            {
                this.label9 = value;
            }
        }
    }
}

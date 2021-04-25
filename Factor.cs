using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Gripper_Design
{
    public partial class Factor : UserControl
    {
        public Factor()
        {
            InitializeComponent();
        }
        public Label Mass_result
        {
            get
            {
                return this.label4;
            }
            set
            {
                this.label4 = value;
            }
        }
        public Label DemoldingForce
        {
            get
            {
                return this.label6;
            }
            set
            {
                this.label6 = value;
            }
        }
    }
}

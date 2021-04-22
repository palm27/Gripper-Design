using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gripper_Design
{
    public partial class Main : Form
    {
        int Count = 0, Count2 = 0;
        int surface_form_index = 0, Demolding_Force_input = 0, Pressure_input = 0, Mass_intput=0;
        Double Cup_diameter = 0;
        static Form _obj;
        public static Form Instance
        {
            get
            {
                if(_obj==null)
                {
                    _obj = new Form();
                }
                return _obj;
            }
        }

        public Main()
        {
            InitializeComponent();
            
        }
        public int CupNumber_calculation(int x, int y)
        {
            int xNumber = 0, yNumber = 0, CupNo = 0;
            xNumber = x / 100;
            yNumber = y / 100;
            CupNo = xNumber * yNumber;
            return CupNo;
        }
        public double SuctionDiameter_calculation(int F, int P)
        {
            double S_Diameter = 0;
            double result = 0;
            S_Diameter = F / P;
            // Convert Area to Diameter
            System.Diagnostics.Debug.WriteLine("Calculation AREA: {0}", S_Diameter);
            S_Diameter = 2 * (Math.Sqrt((S_Diameter/3.14)));
            result = Math.Truncate(S_Diameter*100)/100;
            System.Diagnostics.Debug.WriteLine("Calculation: {0}", result);
            //result = Convert.ToInt32(S_Diameter);
            return result;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void background1_Load(object sender, EventArgs e)
        {
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button10.Hide();
            button11.Hide();
            button13.Hide();
            outerShape1.BringToFront();
            button7.Show();
        }
        // Next shape
        private void button7_Click(object sender, EventArgs e)
        {
            Count++;
            
            if (Count==1)
            {
                innerShape1.BringToFront();
                 button8.Show();

            }
            if (Count == 2)
            {
                upperShape1.BringToFront();
               
            }
            if (Count == 3)
            {
                combineShape1.BringToFront();
                button7.Hide();
                button9.Show();

            }

        }
        // back page shape
        private void button8_Click(object sender, EventArgs e)
        {
            Count--;
            if (Count == 0)
            {
                outerShape1.BringToFront();

            }
            if (Count == 1)
            {
                innerShape1.BringToFront();

            }
            if (Count == 2)
            {
                upperShape1.BringToFront();

            }
            if (Count == 3)
            {
                combineShape1.BringToFront();

            }
        }
        // Back page Vacuum
        private void button13_Click(object sender, EventArgs e)
        {
            Count2--;
            if (Count == 0)
            {
                vacuum_Gripper1.BringToFront();

            }
           
        }
        // Rubber property
        private void button2_Click(object sender, EventArgs e)
        {
            rubberProperty1.BringToFront();
            Count = 0;
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button11.Hide();
            button10.Show();
            button13.Hide();
        }
        // Mold
        private void button5_Click(object sender, EventArgs e)
        {
            mold1.BringToFront();
            button11.Show();
            button12.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button13.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button12.Show();
            button11.Hide();
            gripperSelection1.BringToFront();
        }
        // gripper next
        private void button12_Click(object sender, EventArgs e)
        {
            int cup_number = 0;
            System.Diagnostics.Debug.WriteLine(this.gripperSelection1.Gripper_index);
            // Vacuum gripper
            if(this.gripperSelection1.Gripper_index==0)
            {
                vacuum_Gripper1.BringToFront();
                Count2++;
                button13.Show();
                
                if (Count2 == 2)
                {
                    vacuumGripperResult2.BringToFront();
                    // Cup number calculation
                    surface_form_index = vacuum_Gripper1.Surfaceform.SelectedIndex;
                   // Demolding_Force_input = vacuum_Gripper1.Demolding_value;
                    Mass_intput = vacuum_Gripper1.Mass_value;
                    Pressure_input = vacuum_Gripper1.Pressure_value;
                    cup_number = vacuum_Gripper1.Number_of_SuctionCup;
                   // Pressure_input = vacuum_Gripper1.Pressure.Value;
                    System.Diagnostics.Debug.WriteLine("Demolding_Force_input: {0}", Demolding_Force_input);
                    //Cup_diameter = SuctionDiameter_calculation(Demolding_Force_input, Pressure_input);
                    
                    // Cup Diameter calculation
                    Cup_diameter = SuctionDiameter_calculation(Demolding_Force_input,Pressure_input);
                    System.Diagnostics.Debug.WriteLine("Suction Diameter: {0}", Cup_diameter);
                    System.Diagnostics.Debug.WriteLine("Number of Cups: {0}", cup_number);
                    vacuumGripperResult2.Cupnumber.Text = cup_number.ToString();
                    vacuumGripperResult2.CupDiameter.Text = Cup_diameter.ToString();
                    if(surface_form_index==0)
                    {
                        vacuumGripperResult2.Cuptype.Text = "Flat Type";
                    }
                    else if(surface_form_index==1)
                    {
                        vacuumGripperResult2.Cuptype.Text = "Bellow Type";
                    }
                    //vacuumGripperResult2.CupDiameter.Text = Cup_diameter.ToString();
                }
               
                
            }
            else if(this.gripperSelection1.Gripper_index == 1)
            {

            }
            else if (this.gripperSelection1.Gripper_index == 2)
            {

            }
        }

    }
}

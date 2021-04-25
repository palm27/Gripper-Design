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
        int surface_form_index = 0, Demolding_Force_input = 0;
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
        public int Force_calculation(int Object_mass,int n_cups)
        {   
            int Force = Object_mass*10 * 4;
            Force = Force / n_cups;
            System.Diagnostics.Debug.WriteLine("Force: {0}", Force);
            return Force;
        }
        public double SuctionDiameter_calculation(double F, double P)
        {
            double S_Diameter = 0;
            double result = 0;
            S_Diameter = F / P;
            // Convert Area to Diameter
            System.Diagnostics.Debug.WriteLine("Calculation AREA: {0}", S_Diameter);
            S_Diameter = S_Diameter / 3.14;
            S_Diameter = Math.Sqrt(S_Diameter);
            result = S_Diameter * 2;
            System.Diagnostics.Debug.WriteLine("Diameter(mm) {0}", S_Diameter);
            result = result * 2.45;
            //result = Math.Truncate(S_Diameter * 10) / 10;
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

        private void button6_Click(object sender, EventArgs e)
        {

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
                    int Mass = vacuum_Gripper1.Mass_value;
                    int Pressure = vacuum_Gripper1.Pressure_value;
                    int Numberofcup = vacuum_Gripper1.Number_of_SuctionCup;
                    System.Diagnostics.Debug.WriteLine("Mass: {0}", Mass);
                    System.Diagnostics.Debug.WriteLine("Number of Cups: {0}", Numberofcup);
                    // Pressure_input = vacuum_Gripper1.Pressure.Value;
                    Demolding_Force_input = (int)Force_calculation(Mass, Numberofcup);
                    //Cup_diameter = SuctionDiameter_calculation(Demolding_Force_input, Pressure_input);
                    // Cup Diameter calculation
                    double Force_to_lb = Convert.ToDouble(Demolding_Force_input);
                    Force_to_lb = Force_to_lb * 0.224;
                    double PSI = Convert.ToDouble(Pressure);
                    PSI = PSI * 0.145;
                    System.Diagnostics.Debug.WriteLine("Demolding_Force_input(N): {0}", Demolding_Force_input);
                    System.Diagnostics.Debug.WriteLine("Demolding_Force_input(lbs): {0}", Force_to_lb);
                    System.Diagnostics.Debug.WriteLine("PSI: {0}", PSI);
                    Cup_diameter = SuctionDiameter_calculation(Force_to_lb, PSI);
                    System.Diagnostics.Debug.WriteLine("Suction Diameter: {0}", Cup_diameter);
                    
                    vacuumGripperResult2.Cupnumber.Text = Numberofcup.ToString();
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

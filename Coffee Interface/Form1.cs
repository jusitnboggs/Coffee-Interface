using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Interface
{
    public partial class CoffeeInterface : Form
    {
        string cFlavor = "";
        string cAddons1 = "";
        string cAddons2 = "";
        string cAddons3 = "";
        public CoffeeInterface()
        {
            InitializeComponent();
        }

        private void Flavors_Enter(object sender, EventArgs e)
        {
            
        }

        private void order_Click(object sender, EventArgs e)
        {
            GetFlavors(radioButton1);
            GetFlavors(radioButton2);
            GetFlavors(radioButton3);
            //GetPrice(); //Debugging
            //GetAddons(comboBox1);
            //GetAddons(comboBox2);
            //GetAddons(comboBox3);

        }

        private void GetFlavors(RadioButton rdoButton)
        {
            if (rdoButton.Checked)
            {
                cFlavor = rdoButton.Text;
                MessageBox.Show(rdoButton.Text); //Here for debuging.
            }
        }

        private void GetAddons(CheckBox CheckB, ComboBox ComBo )
        {
            if(CheckB.Checked)
            {
                cAddons1 =" and " + comboBox1.Text; //Suager
                cAddons2 = " with " + comboBox2.Text; //Cream
                cAddons3 = " with " + comboBox3.Text; //Shot
                GetPrice();


            }
        }

        private void GetPrice()
        {
            MessageBox.Show(cFlavor + cAddons2 + cAddons1 + cAddons3 + " That will be $500");
        }
       
    }
}

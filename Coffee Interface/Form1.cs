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
        public CoffeeInterface()
        {
            InitializeComponent();
        }

        private void Flavors_Enter(object sender, EventArgs e)
        {
            
        }

        //private void GetFlavors(RadioButton rdoButton)
        //{
            //if (rdoButton.Checked)
           // {
                //cFlavor = rdoButton.Text;
               // MessageBox.Show(rdoButton.Text);
          //  }

       // }

        private void order_Click(object sender, EventArgs e)
        {
             private void GetFlavors(RadioButton rdoButton)
            {
                if (rdoButton.Checked)
                {
                    //cFlavor = rdoButton.Text;
                    MessageBox.Show(rdoButton.Text);
                }

            }
        }
    }
}

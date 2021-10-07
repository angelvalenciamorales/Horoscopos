using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horoscopos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*-----------Variables------------*/
        int mes, dia;

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            dia = Convert.ToInt32(cboListDia.Text);
            mes = cboListMes.SelectedIndex + 1;
            lblMostrar.Text = "";

            //if ((dia >= 20 && dia <= 31 && mes == 1) || (dia >= 1 && dia <= 18 && mes == 2 )) 
            //Enero 20 – Febrero 18

            switch (mes)
            {
                //Acuario
                case 1:
                    if (dia >= 20 && dia <= 31 && mes == 1)
                    {
                        lblMostrar.Text = "Acuario";
                    }
                    break;

                case 2:
                    //Acuario
                     if (dia >= 1 && dia <= 18 && mes == 2)
                    {
                        lblMostrar.Text = "Acuario";
                    }

                     //pucisis
                     if(dia >=19 && dia <= 31 && mes == 2)
                    {
                        lblMostrar.Text = "Piscis";
                    }
                    break; // error de pocision 
                    
                case 3:
                    //pucsis
                    if(dia >= 21 && dia <= 31 && mes == 3){
                        lblMostrar.Text = "Aries";
                    }

                    if (dia <= 30 && dia <= 20 && mes == 3)
                    {
                        lblMostrar.Text = "Piscis";
                    }
                    break; // error de pocision 

                    //Aries






            }
        }
    }
}

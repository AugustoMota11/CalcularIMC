using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
       
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);

            double imc = peso / (altura * altura);

            txtResultado.Text = Math.Round(imc, 2).ToString();  

            if (imc < 18.5)
            {
                lblFaixa.Text = "Abaixo do peso";
            }

            else if (imc < 18.6 && imc < 24.9)
            {
                lblFaixa.Text = "Peso ideal (PARABÉNS)";
            }
            
            else if(imc < 25.0 && imc < 29.9)
            {
                lblFaixa.Text = "Levemente acima do peso";
            }
            
            else if(imc < 30.0 && imc < 34.9)
            {
                lblFaixa.Text = "Obesidade grau 1";
            }
            
            else if (imc < 35.0 && imc < 39.9)
            {
                lblFaixa.Text = "Obesidade grau 2 (severa)";
            }

            else if (imc >= 40)
            {
                lblFaixa.Text = "Obesidade 3 (mórbida)";
            }
                

        
        
        
        
        
        
        
        
        
        
        
        
        }
        
        
        

    }
}

using Servicio.AppWind.ProxyWCF;
using System;
using System.Windows.Forms;

namespace Servicio.AppWind
{
    public partial class CalculadoraView : Form
    {
        //crear objeto de la clase Calculadora del servicio
        CalculadoraClient obj = new CalculadoraClient();
        public CalculadoraView()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            procesar(1);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            procesar(2);
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            procesar(3);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            procesar(4);
        }


        private void btnMR_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEX_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void procesar(int opcion)
        {
            decimal res = 0;
            switch (opcion)
            {
                case 1:
                    res = obj.Sumar(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
                    break;
                case 2:
                    res = obj.Restar(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
                    break;
                case 3:
                    res = obj.Multiplicar(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
                    break;
                case 4:
                    res = obj.Dividir(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
                    break;
                case 5:
                    res = ((decimal)obj.raiz(Convert.ToDecimal(txtNum1.Text), decimal.Parse(txtNum2.Text)));
                    break;
                case 6:
                    res = ((decimal)obj.cuadrado(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)));
                    break;
            }
            txtResultado.Text = res.ToString();
        }

        private void Limpiar()
        {

        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            procesar(5);
        }

        private void btn_cuadrado_Click(object sender, EventArgs e)
        {
            procesar(6);
        }
    }
}

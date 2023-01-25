using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace imcpesoideal

{

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();

        }



        private void btnSair_Click(object sender, EventArgs e)

        {

            this.Close();

        }



        private void btnLimpar_Click(object sender, EventArgs e)

        {

            txtName.Clear();

            txtAltura.Clear();

            cmbSexo.Text = "";

            txtName.Focus();

        }



        private void btnPesoIdeal_Click(object sender, EventArgs e)

        {

            Double Altura = 0, Pesoideal = 0;

            Altura = double.Parse(txtAltura.Text);

            if (cmbSexo.Text == "Feminino")

            {

                Pesoideal = (62.7 * Altura) - 44.7;

                MessageBox.Show(txtName.Text + "Seu peso ideal é:  " + Pesoideal.ToString(), "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



            else if (cmbSexo.Text == "Masculino")

            {

                Pesoideal = (72.7 * Altura) - 58;

                MessageBox.Show(txtName.Text + "Seu peso ideal é:  " + Pesoideal.ToString(), "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



            else

            {

                MessageBox.Show("Escolha o sexo", "Peso ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

    }

}

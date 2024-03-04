using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex01
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            double Basee, altura, areaa;
            Basee = Convert.ToDouble(textBase.Text.Replace('.', ','));
            altura = Convert.ToDouble(textAltura.Text.Replace('.', ','));

            areaa = Basee * altura;

            lblSaida.Text = "A area do retangulo é " + areaa;
        }
    }
    }

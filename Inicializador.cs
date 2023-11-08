using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorOVNI
{
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
        }

        private void Inicializador_Load(object sender, EventArgs e)
        {
            cmbPlaneta.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Obter as informações do form:

            int maxTripulantes = (int)nudTripulantes.Value;
            int maxAbduzidos = (int)nudAbduzidos.Value;
            string planetaOrigem = cmbPlaneta.Text;

            //instanciar o OVNI:
            BibliotecaOVNI.OVNI ovni = 
                new BibliotecaOVNI.OVNI(maxTripulantes, maxAbduzidos, planetaOrigem);

            //instanciar painel:
            Painel janela = new Painel(ovni);
            //abrir painel:
            janela.ShowDialog();
        }
    }
}

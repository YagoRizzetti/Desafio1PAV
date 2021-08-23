using Practica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Principal : Form
    {
        public Principal(Usuario usu)
        {
            InitializeComponent();
            labelBienvenida.Text = "Bienvenio " + usu.NombreDeUsuario;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}

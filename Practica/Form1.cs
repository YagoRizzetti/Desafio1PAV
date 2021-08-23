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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(textBoxUserName.Text, textBoxPassword.Text);

            string nombre = textBoxUserName.Text;
            string contraseña = textBoxPassword.Text;

            string nombreCorrecto = "Yago";
            string contraseñaCorrecta = "123456";

            if (nombre.Equals(nombreCorrecto) && contraseña.Equals(contraseñaCorrecta))
            {
                Principal ventana = new Principal(usu);
                ventana.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Invalida");

            }

        }
    }
}

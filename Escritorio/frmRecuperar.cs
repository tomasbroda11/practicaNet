using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broda.Escritorio
{
    public partial class frmRecuperar : Form
    {
        public frmRecuperar()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string cuil = txtCuil.Text;
            try
            {
                if(Negocio.Validaciones.EsCuilValido(cuil))
                { 
                Entidades.Docente docente = Broda.Negocio.Docente.RecuperarUno(cuil);
                lblId.Text = docente.Id.ToString();
                lblNombre.Text = docente.ApellidoNombre.ToString();
                lblEmail.Text = docente.Mail.ToString();
                lblFecha.Text = docente.FechaIngreso.ToString();
                lblSalario.Text = docente.Salario.ToString();
                lblError.Text = "";
                }
                else
                {
                    throw new Exception("Cuil Invalido");
                }
            }
           
            catch(Exception ex) 
            {
                lblError.Text = ex.Message;  
            }   
        }
    }
}

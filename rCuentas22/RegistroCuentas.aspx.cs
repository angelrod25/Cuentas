using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace rCuentas22
{
    public partial class RegistroCuentas : System.Web.UI.Page
    {
        Cuentas c = new Cuentas();
        int IdC;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                c = new Cuentas();

                c.Descripcion = tbDescripcion.Text;
                c.Balance = float.Parse(tbBalance.Text);

                if (!tbCuentaId.Text.Equals(string.Empty))
                {
                    int id = int.Parse(tbCuentaId.Text);

                    if (c.modificar(id))
                    {
                        Response.Write("Se ha modificado la cuenta exitosamente, Felicidades!");
                        tbCuentaId.Text = "";
                        tbDescripcion.Text = "";
                        tbBalance.Text = "";
                    }
                    else
                    {
                        Response.Write("Ocurrió un error Insertando la cuenta a la base de datos, favor intente de nuevo o comunicarse con Angel Rodríguez para asistencia");
                    }
                }

                if (tbCuentaId.Text.Equals(string.Empty))
                {
                    if (c.insertar())
                    {
                        Response.Write("Se ha insertado la cuenta exitosamente, Felicidades!");
                        tbCuentaId.Text = "";
                        tbDescripcion.Text = "";
                        tbBalance.Text = "";
                    }
                    else
                    {
                        Response.Write("Ocurrió un error Insertando la cuenta a la base de datos, favor intente de nuevo o comunicarse con Angel Rodríguez para asistencia");
                    }
                }


            }
            catch (Exception sq)
            {
                Response.Write(sq.Message);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // tbDescripcion.Enabled = false; <<< Esto sirve para que no puedan editar este TB depués que está lleno OK

            if (!tbCuentaId.Text.Equals(string.Empty))
            {
                int.TryParse(tbCuentaId.Text, out IdC);
                c.BuscarL(IdC);
                tbDescripcion.Text = c.Descripcion;
                tbBalance.Text = c.Balance.ToString();

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrWhiteSpace(tbCuentaId.Text))
                {
                    int id = int.Parse(tbCuentaId.Text);
                    c.eliminar(id);
                    Response.Write("Cuenta Eliminasda Con Exito");
                    tbCuentaId.Text = "";
                    tbDescripcion.Text = "";
                    tbBalance.Text = "";
                }
            }
        }
    }
}
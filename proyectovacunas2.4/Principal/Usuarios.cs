using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaBD;
using System.Security.Cryptography;

namespace proyectovacunas2._4
{
    public partial class Usuarios : Form
    {
        public static string UsuarioActual { get; set; }
        public static int IDCargo { get; set; }


        CapaBD.ConexionBD conexion = new CapaBD.ConexionBD();
        public Usuarios()
        {
            InitializeComponent();
            this.KeyDown += Usuarios_KeyDown;
            this.KeyPreview = true; // Habilitar la captura de teclas en el formulario
        }
        private void Usuarios_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si se presionó la tecla Enter (código 13)
            if (e.KeyCode == Keys.Enter)
            {
                // Evitar que se genere un evento Click en algún botón predeterminado (si lo hay)
                e.Handled = true;
                e.SuppressKeyPress = true;
                string usuario = Usuarios_textBox1.Text.Trim();
                string contraseña = Contraseña_textBox2.Text.Trim();

                // Llamar al método constructor propio
                logear(usuario, contraseña);
            }
        }

        private void logear(string usuario, string contraseña)
        {
            try
            {
                conexion.cn.Open();

                SqlCommand cmd = new SqlCommand("sp_INICIARSESION", conexion.cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_USUARIO", usuario);
                cmd.Parameters.AddWithValue("@p_CONTRASENA", contraseña);
                cmd.Parameters.Add("@p_INICIO_EXITOSO", SqlDbType.Bit).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                // Obtener el valor de @p_INICIO_EXITOSO después de ejecutarlo
                bool inicioExitoso = Convert.ToBoolean(cmd.Parameters["@p_INICIO_EXITOSO"].Value);

                if (inicioExitoso)
                {
                    // Obtener el valor de ID_CARGO del usuario
                    SqlCommand idCargoCmd = new SqlCommand("SELECT ID_CARGO_EMPLEADO FROM EMPLEADO WHERE USUARIO = @p_USUARIO", conexion.cn);
                    idCargoCmd.Parameters.AddWithValue("@p_USUARIO", usuario);
                    IDCargo = Convert.ToInt32(idCargoCmd.ExecuteScalar());

                    // Verificar si el usuario está activo en la tabla EMPLEADO
                    SqlCommand activoCmd = new SqlCommand("SELECT ACTIVO FROM EMPLEADO WHERE USUARIO = @p_USUARIO", conexion.cn);
                    activoCmd.Parameters.AddWithValue("@p_USUARIO", usuario);

                    bool empleadoActivo = Convert.ToBoolean(activoCmd.ExecuteScalar());

                    if (empleadoActivo)
                    {
                        UsuarioActual = usuario;
                        this.Hide();
                        new frmPrincipal().Show();
                    }
                    else
                    {
                        MessageBox.Show("El empleado está inactivo.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.cn.Close();
            }
        }



        private void btnLoggin_Click(object sender, EventArgs e)
        {

            string usuario = Usuarios_textBox1.Text.Trim();
            string contraseña = Contraseña_textBox2.Text.Trim();
            // Llamar al método constructor propio
            logear(usuario, contraseña);

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void chkVer_CheckedChanged_1(object sender, EventArgs e)
        {
            // Verificar si la casilla de verificación está marcada
            if (chkVer.Checked)
            {
                // Si está marcada, mostrar la contraseña
                Contraseña_textBox2.UseSystemPasswordChar = false; // Esto muestra la contraseña como texto normal
            }
            else
            {
                // Si no está marcada, ocultar la contraseña
                Contraseña_textBox2.UseSystemPasswordChar = true; // Esto oculta la contraseña
            }
        }

        private void botonsalir_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

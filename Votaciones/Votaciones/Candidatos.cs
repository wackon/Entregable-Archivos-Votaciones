using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Votaciones
{
    public partial class Candidatos : Form
    {
        public Candidatos()
        {
            InitializeComponent();
        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            // Metodos.Metodos.validar(txValorVoto.Text.Trim();

            int voto;

            try
            {

                if (txValorVoto.Text == null || Int32.Parse(txValorVoto.Text) <= 0 || Int32.Parse(txValorVoto.Text) >= 11)
                {
                    MessageBox.Show("Ingrese un Valor Válido");
                }
                else
                {
                    voto = Int32.Parse(txValorVoto.Text.Trim());

                    for (int i = 1; i <= voto; i++)
                    {

                        if (i == voto)
                        {
                            DB objDB = new DB();

                            SqlConnection objConector = objDB.conectar("CANDIDATOS");
                            string sql = "select * from ELEJIDOS Where NUMEROTARJETON =" + txValorVoto.Text;
                            SqlDataReader tabla = objDB.consulta(sql, objConector);


                            string campo = txValorVoto.Text;

                            if (tabla.Read())
                            {
                                int valor = Int32.Parse(tabla[2].ToString());
                                tabla.Close();

                                valor += 1;

                                string sql1 = " update ELEJIDOS set CANTIDADVOTOS = " + valor + " where NUMEROTARJETON = " + txValorVoto.Text;
                                objDB.operar(sql1, objConector);
                                tabla.Close();
                                objConector.Close();
                                txMen.Text = "Su voto ha sido registrado";
                                btVotar.Enabled = false;
                                txValorVoto.Text = "";
                                btLimpiar.Enabled = false;

                                break;
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Candidatos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cANDIDATOSDataSet2.ELEJIDOS' Puede moverla o quitarla según sea necesario.
            this.eLEJIDOSTableAdapter1.Fill(this.cANDIDATOSDataSet2.ELEJIDOS);
            // TODO: esta línea de código carga datos en la tabla 'cANDIDATOSDataSet.ELEJIDOS' Puede moverla o quitarla según sea necesario.
           // this.eLEJIDOSTableAdapter.Fill(this.cANDIDATOSDataSet.ELEJIDOS);

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txValorVoto.Text = "";
        }
    }
}

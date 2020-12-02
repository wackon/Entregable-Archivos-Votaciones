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

namespace Votaciones
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cANDIDATOSDataSet3._Candidato_Votos' Puede moverla o quitarla según sea necesario.
            this.candidato_VotosTableAdapter1.Fill(this.cANDIDATOSDataSet3._Candidato_Votos);
            // TODO: esta línea de código carga datos en la tabla 'cANDIDATOSDataSet1._Candidato_Votos' Puede moverla o quitarla según sea necesario.
            //this.candidato_VotosTableAdapter.Fill(this.cANDIDATOSDataSet1._Candidato_Votos);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB objDB = new DB();

            SqlConnection objConector = objDB.conectar("CANDIDATOS");

            string verde = "VERDE";
            string sql = "select SUM(CANTIDADVOTOS) from ELEJIDOS where PARTIDO='" + verde + "'";

            SqlDataReader tabla = objDB.consulta(sql, objConector);

            tabla.Read();

            string valor = tabla[0].ToString();

            txVerde.Text = valor;
            tabla.Close();


            string rojo = "ROJO";
            string sql1 = "select SUM(CANTIDADVOTOS) from ELEJIDOS where PARTIDO='" + rojo + "'";

            SqlDataReader tabla1 = objDB.consulta(sql1, objConector);

            tabla1.Read();

            string valor1 = tabla1[0].ToString();

            txRojo.Text = valor1;
            tabla1.Close();


            string naranja = "NARANJA";
            string sql2 = "select SUM(CANTIDADVOTOS) from ELEJIDOS where PARTIDO='" + naranja + "'";

            SqlDataReader tabla2 = objDB.consulta(sql2, objConector);

            tabla2.Read();

            string valor2 = tabla2[0].ToString();

            txNaranja.Text = valor2;
            tabla2.Close();


            string azul = "AZUL";
            string sql3 = "select SUM(CANTIDADVOTOS) from ELEJIDOS where PARTIDO='" + azul + "'";

            SqlDataReader tabla3 = objDB.consulta(sql3, objConector);

            tabla3.Read();

            string valor3 = tabla3[0].ToString();

            txAzul.Text = valor3;
            tabla3.Close();


            string gris = "GRIS";
            string sql4 = "select SUM(CANTIDADVOTOS) from ELEJIDOS where PARTIDO='" + gris + "'";

            SqlDataReader tabla4 = objDB.consulta(sql4, objConector);

            tabla4.Read();

            string valor4 = tabla4[0].ToString();

            txGris.Text = valor4;
            tabla4.Close();
            objConector.Close();
        }

        private void txNaranja_TextChanged(object sender, EventArgs e)
        {

        }

        private void txVerde_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = 0;
            int k= 0;
            int mayor = 0;
            int pos = 0;
            int cont = 0;

            int[] datos = new int[10];
            DB objDB = new DB();

            SqlConnection objConector = objDB.conectar("CANDIDATOS");

            //string sql = "select cantidadvotos ca, nombre  from Elejidos group by nombre order by ca";
            string sql = "select CANTIDADVOTOS from ELEJIDOS WHERE NUMEROTARJETON =  '1'";
            SqlDataReader tabla = objDB.consulta(sql, objConector);

            tabla.Read();
            datos[0] = Int32.Parse(tabla[0].ToString());
            tabla.Close();


            string sql1 = "select CANTIDADVOTOS from ELEJIDOS WHERE NUMEROTARJETON =  '2'";
            SqlDataReader tabla1 = objDB.consulta(sql1, objConector);

            tabla1.Read();
            datos[1] = Int32.Parse(tabla1[0].ToString());
            tabla1.Close();


            string sql2 = "select CANTIDADVOTOS from ELEJIDOS WHERE NUMEROTARJETON =  '3'";
            SqlDataReader tabla2 = objDB.consulta(sql2, objConector);

            tabla2.Read();
            datos[2] = Int32.Parse(tabla2[0].ToString());
            tabla2.Close();


            string sql3 = "select CANTIDADVOTOS from ELEJIDOS WHERE NUMEROTARJETON =  '4'";
            SqlDataReader tabla3 = objDB.consulta(sql3, objConector);

            tabla3.Read();
            datos[3] = Int32.Parse(tabla3[0].ToString());
            tabla3.Close();


            string sql4 = "select CANTIDADVOTOS from ELEJIDOS WHERE NUMEROTARJETON =  '5'";
            SqlDataReader tabla4 = objDB.consulta(sql4, objConector);

            tabla4.Read();
            datos[4] = Int32.Parse(tabla4[0].ToString());
            tabla4.Close();

            string sql5 = "select CANTIDADVOTOS from ELEJIDOS WHERE NUMEROTARJETON =  '6'";
            SqlDataReader tabla5 = objDB.consulta(sql5, objConector);

            tabla5.Read();
            datos[5] = Int32.Parse(tabla5[0].ToString());
            tabla5.Close();

            string sql6 = "select CANTIDADVOTOS from ELEJIDOS WHERE NUMEROTARJETON =  '7'";
            SqlDataReader tabla6 = objDB.consulta(sql6, objConector);

            tabla6.Read();
            datos[6] = Int32.Parse(tabla6[0].ToString());
            tabla6.Close();


            string sql7 = "select CANTIDADVOTOS from ELEJIDOS WHERE NUMEROTARJETON =  '8'";
            SqlDataReader tabla7 = objDB.consulta(sql7, objConector);

            tabla7.Read();
            datos[7] = Int32.Parse(tabla7[0].ToString());
            tabla7.Close();


            string sql8 = "select CANTIDADVOTOS from ELEJIDOS WHERE NUMEROTARJETON =  '9'";
            SqlDataReader tabla8 = objDB.consulta(sql8, objConector);

            tabla8.Read();
            datos[8] = Int32.Parse(tabla8[0].ToString());
            tabla8.Close();


            string sql9 = "select CANTIDADVOTOS from ELEJIDOS WHERE NUMEROTARJETON =  '10'";
            SqlDataReader tabla9 = objDB.consulta(sql9, objConector);

            tabla9.Read();
            datos[9] = Int32.Parse(tabla9[0].ToString());
            tabla9.Close();
            objConector.Close();


            while (j < 10)
            {
                if (datos[j] > mayor)
                {
                    mayor = datos[j];
                    pos = j;
                }
                j += 1;
            }


            while (k < 10)
            {
                if (datos[k] == mayor)
                {
                    cont += 1;
                }
                k += 1;
            }

            if (cont != 1)
            {
                txSalida.Text = "No se ha determinado un ganador\r\n" +
                    " EMPATE entre los Candidatos";
            }
            else
            {
                if (pos == 0)
                {
                    txSalida.Text = "El ganador es DANIEL";
                }
                else if (pos == 1)
                {
                    txSalida.Text = "La ganadora es CAMILA";
                }
                else if (pos == 2)
                {
                    txSalida.Text = "El ganador es JOSE";
                }
                else if (pos == 3)
                {
                    txSalida.Text = "La ganadora es ANA";
                }
                else if (pos == 4)
                {
                    txSalida.Text = "El ganador es MATEO";
                }
                else if (pos == 5)
                {
                    txSalida.Text = "El ganador es CARLOS";
                }
                else if (pos == 6)
                {
                    txSalida.Text = "El ganador es  SANTIAGO";
                }
                else if (pos == 7)
                {
                    txSalida.Text = "El ganador es BRYAN";
                }
                else if (pos == 8)
                {
                    txSalida.Text = "El ganador es RAMIRO";
                }
                else if (pos == 9)
                {
                    txSalida.Text = "El ganador es ANDRES";
                }

            }
        }
    }
}


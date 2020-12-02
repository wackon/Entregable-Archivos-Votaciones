using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Votaciones
{
    public partial class Logueo : Form
    {
        

        public Logueo()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            //
            string nombre = txNom.Text.Trim();
            string cuenta = txCedula.Text.Trim();
            //Cambiar la dirección por la del archivo local en el equipo
            string url = "C:\\Users\\yesid\\Downloads\\Votaciones\\Votaciones\\Votantes" + ".txt";

            if (File.Exists(url))
            {

                StreamReader sr = new StreamReader(url, Encoding.Default);
                
                string cc = txCedula.Text;
                string nom = txNom.Text;
                int existe = 0;
                string[] Votante = new string[3];
                string[] Vaux = new string[3];

                int n = 0;
                while (sr.ReadLine() != null)
                {
                    n = n + 1;
                }

                string[] lines = new string[n];

                sr.BaseStream.Position = 0;
                string text = "";
                int pos = 0;

                while (text != null && pos < n)
                {
                    text = sr.ReadLine();
                    lines[pos] = text;
                    pos = pos + 1;
                }

                for (int i = 0; i < n; i++)
                {
                    string aux = lines[i];

                    Votante = aux.Split(',');

                   
                    if (cc.Equals(Votante[1]) && nom.Equals(Votante[0]))
                    {
                        
                        existe = 1;
                        if (Int32.Parse(Votante[2]) == 1)
                        {
                            MessageBox.Show("El usuario ya voto");
                        }
                        else if (Int32.Parse(Votante[2]) == 0)
                        {
                            MessageBox.Show("El usuario puede votar");
                            sr.Close();
                            StreamWriter SW = new StreamWriter(url);
                            for (int j =0; j<n; j++)
                            {
                                if (j==i)
                                {
                                    Vaux = aux.Split(',');
                                    SW.WriteLine(Vaux[0]+","+Vaux[1]+","+"1");
                                }
                                else
                                {
                                    SW.WriteLine(lines[j]);
                                }
                            }
                            SW.Close();
                            Principal objp = new Principal();
                            objp.Show();
                            this.Hide();
                        }

                    }

                }

                if (existe == 0)
                {

                    MessageBox.Show("El usuario no esta inscrito para votar");
                }

            }
            else
            {
                MessageBox.Show("ERROR... No se pudo encontrar el archivo");
            }

        }
        
     
    }
    
}
    
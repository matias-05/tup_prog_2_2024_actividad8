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
using Actividad8.Models;

namespace Actividad8
{
    public partial class Form1 : Form
    {
        Banco banco = new Banco();
        public Form1()
        {   
            InitializeComponent();
           
            banco.AgregarCuenta(001, 44345212,"Franco Mastantuono");
            banco.AgregarCuenta(002, 44345212, "Franco Mastantuono");
            banco.AgregarCuenta(003, 48230123, "Mateo Jaeger");
            banco.AgregarCuenta(004, 32423211, "Matias Ascasibar");
            banco.AgregarCuenta(005, 39412031, "Gabriel Hernandez");
            banco.AgregarCuenta(006, 31312534, "Juan Ronaldo");
        }

        private void btVerCuentas_Click(object sender, EventArgs e)
        {

        }

        private void btImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Importación de cuentas";
            openFileDialog1.Filter = "fichero csv|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string linea;
                    while (sr.EndOfStream == false)
                    {
                        linea = sr.ReadLine();
                        string[] campos = linea.Split(';');

                        int dni = Convert.ToInt32(campos[0].Trim());
                        string nombre = campos[1].Trim();
                        int numeroCuenta = Convert.ToInt32(campos[2].Trim());
                        double saldo = Convert.ToDouble(campos[3].Trim());
                        
                        Cuenta cuenta = banco.AgregarCuenta(dni, numeroCuenta, nombre);
                        cuenta.Saldo = saldo;
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al importar la cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) sr.Close();
                }

                btVerCuentas.PerformClick();
            }
        }
    }
}

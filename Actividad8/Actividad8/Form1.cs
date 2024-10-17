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
        }

    }
}

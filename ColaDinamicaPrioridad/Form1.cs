using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaDinamicaPrioridad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cola prio = new Cola();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = txtDato.Text;
            nuevo.Prioridad = int.Parse(txtPri.Text);
            prio.Agregar(nuevo);
            txtDato.Text = "";
            txtPri.Text = "";
            txtCola.Text = prio.ToString();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            prio.CrearArreglo(int.Parse(txtNum.Text));
            grbFirst.Visible = false;
            grbSec.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grbFirst.Visible = true;
            grbSec.Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            prio.Eliminar();
            txtCola.Text = prio.ToString();
        }
    }
}

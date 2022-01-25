using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Vemta_de_Boletos
{
    public partial class frmCine : Form
    {
        ListViewItem item;
        double precio = 0;
        string categoria = "";



        public frmCine()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoria = lblCategoria.Text;
            int cantidad = int.Parse(txtCantidad.Text);




            double subtotal = precio * cantidad;
            double descuento = 0;

            switch (categoria)
            {
                case "Niño":
                    descuento = 20.0 / 100 * subtotal;

                    break;

                case "JovenI":
                    descuento = 10.0 / 100 * subtotal;
                    break;

                case "JovenII":
                    descuento = 5.0 / 100 * subtotal;
                    break;

                case "AdultoI":
                    descuento = 10.0 / 100 * subtotal;
                    break;

                case "AdultoII":
                    descuento = 20.0 / 100 * subtotal;
                    break;

            }

            double importe = subtotal - descuento;

            ListViewItem fila = new ListViewItem(categoria);

            fila.SubItems.Add(precio.ToString("0.00"));

            fila.SubItems.Add(cantidad.ToString());

            fila.SubItems.Add(subtotal.ToString("0.00"));

            fila.SubItems.Add(descuento.ToString("0.00"));

            fila.SubItems.Add(importe.ToString("0.00"));

            lvRegistro.Items.Add(fila);

            lvEstadisticas.Items.Clear();


        }

        private void cbEdad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int edad = cbEdad.SelectedIndex;

            switch (edad)
            {
                case 0: precio = 10; categoria = "Niño"; break;
                case 1: precio = 15; categoria = "JovenI"; break;
                case 2: precio = 25; categoria = "JovenII"; break;
                case 3: precio = 15; categoria = "AdultoI"; break;
                case 4: precio = 10; categoria = "AdultoII"; break;
            }

            lblPrecio.Text = precio.ToString("C");

            lblCategoria.Text = categoria;


            if (cbEdad.SelectedItem.Equals("01 - 12"))
            {
                image_Niño.Visible = true;
                JovenII.Visible = false;
                J2.Visible = false;
                AdultoI.Visible = false;
                A2.Visible = false;

                Bryan.Visible = true;
                Jhon.Visible = false;
                Oscar.Visible = false;
                Zacarias.Visible = false;
                LeandroKun.Visible = false;
            }

            if (cbEdad.SelectedItem.Equals("13 - 18"))
            {
                image_Niño.Visible = false;
                JovenII.Visible = true;
                J2.Visible = false;
                AdultoI.Visible = false;
                A2.Visible = false;

                Bryan.Visible = false;
                Jhon.Visible = true;
                Oscar.Visible = false;
                Zacarias.Visible = false;
                LeandroKun.Visible = false;


            }

            if (cbEdad.SelectedItem.Equals("19 - 26"))
            {
                image_Niño.Visible = false;
                JovenII.Visible = false;
                J2.Visible = true;
                AdultoI.Visible = false;
                A2.Visible = false;

                Bryan.Visible = false;
                Jhon.Visible = false;
                Oscar.Visible = true;
                Zacarias.Visible = false;
                LeandroKun.Visible = false;
            }

            if (cbEdad.SelectedItem.Equals("27 - 60"))
            {
                image_Niño.Visible = false;
                JovenII.Visible = false;
                J2.Visible = false;
                AdultoI.Visible = true;
                A2.Visible = false;

                Bryan.Visible = false;
                Jhon.Visible = false;
                Oscar.Visible = false;
                Zacarias.Visible = true;
                LeandroKun.Visible = false;
            }
            if (cbEdad.SelectedItem.Equals("60 a Mas"))
            {
                image_Niño.Visible = false;
                JovenII.Visible = false;
                J2.Visible = false;
                AdultoI.Visible = false;
                A2.Visible = true;

                Bryan.Visible = false;
                Jhon.Visible = false;
                Oscar.Visible = false;
                Zacarias.Visible = false;
                LeandroKun.Visible = true;
            }

        }

        private void brnMostrar_Click(object sender, EventArgs e)
        {
            lvEstadisticas.Items.Clear();

            double tSubTotal = 0;

            int i;
            for (i = 0; i < lvRegistro.Items.Count; i++)
            {
                tSubTotal += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
            }

            double tDescuento = 0;

            i = 0;
            while (i < lvRegistro.Items.Count)
            {
                tDescuento += double.Parse(lvRegistro.Items[i].SubItems[4].Text);
                i++;
            }

            double aNiño = 0, aJovenI = 0, aJovenII = 0, aAdultoI = 0, aAdultoII = 0;

            i = 0;

            do
            {
                string categoria = lvRegistro.Items[i].SubItems[0].Text;

                switch (categoria)
                {

                    case "Niño":
                        aNiño += double.Parse(lvRegistro.Items[i].SubItems[5].Text);
                        break;

                    case "JovenI": aJovenI += double.Parse(lvRegistro.Items[i].SubItems[5].Text); break;

                    case "JovenII": aJovenII += double.Parse(lvRegistro.Items[i].SubItems[5].Text); break;

                    case "AdultoI": aAdultoI += double.Parse(lvRegistro.Items[i].SubItems[5].Text); break;

                    case "AdultoII": aAdultoII += double.Parse(lvRegistro.Items[i].SubItems[5].Text); break;
                }
                i++;

            } while (i < lvRegistro.Items.Count);

            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Monto total sin Descuento";
            elementosFila[1] = tSubTotal.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto total que la Empresa no percibe";
            elementosFila[1] = tDescuento.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto Acumulado por Categoria Niño";
            elementosFila[1] = aNiño.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto Acumulado por Categoria JovenI";
            elementosFila[1] = aJovenI.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto Acumulado por Categoria JovenII";
            elementosFila[1] = aJovenII.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto Acumulado por Categoria AdultoI";
            elementosFila[1] = aAdultoI.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto Acumulado por Categoria AdultoII";
            elementosFila[1] = aAdultoII.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro que quieres salir?", "Control de Ventas",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmCine_Load(object sender, EventArgs e)
        {
            image_Niño.Visible = false;
            JovenII.Visible = false;
            J2.Visible = false;
            AdultoI.Visible = false;
            A2.Visible = false;

            Bryan.Visible = false;
            Jhon.Visible = false;
            Oscar.Visible = false;
            Zacarias.Visible = false;
            LeandroKun.Visible = false;


        }

        private void lvRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvRegistro_MouseClick(object sender, MouseEventArgs e)
        {
            item = lvRegistro.GetItemAt(e.X, e.Y);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvRegistro.Items.Clear();
            lvEstadisticas.Items.Clear();
            txtCantidad.Clear();
            lblPrecio.Text = "";
            lblCategoria.Text = "";
            cbEdad.Text = "";


            txtRazonSocial.Clear();
            txtRazonSocial.Focus();


        }
    }
}

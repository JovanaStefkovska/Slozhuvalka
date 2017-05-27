using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Wlc : Form
    {
        public static string ImeIgrac = "";
        public static Image Basic;
        
        public Wlc()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zapochni_Click(object sender, EventArgs e)
        {
            int nivo = cB1.SelectedIndex;
            if (nivo == 0)
            {
                ImeIgrac = Ime.Text;
                if(Basic==null)
                    MessageBox.Show("Немате избрано слика!");
                else { 

                this.Hide();
                Pocetnik prozorec0 = new Pocetnik();
                prozorec0.ShowDialog();
                }
                //this.Close();
            }
            else if (nivo == 1)
            {
                if (Basic == null)
                    MessageBox.Show("Немате избрано слика!");
                else
                {
                    this.Hide();
                    Napreden prozorec1 = new Napreden();
                    prozorec1.ShowDialog();
                }
                //this.Close();
            }
            else
            {
                MessageBox.Show("Немате избрано ниво!");
            }
        }

        private void Ime_Validated(object sender, EventArgs e)
        {

        }

        private void Ime_Validating(object sender, CancelEventArgs e)
        {
            if (Ime.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorIme.SetError(Ime, "Внесете го вашето име!");
            }
            else errorIme.SetError(Ime, null);
        }

        private void izberiSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (JPEG,GIF,BMP,PNG,JPG)|*.jpeg;*.bmp;*.png;*.jpg";
            openDialog.RestoreDirectory = true;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {     //kako da se prenesuva slikata vo drugite formi
                Basic = Image.FromFile(openDialog.FileName);
            }
        }
    }
}

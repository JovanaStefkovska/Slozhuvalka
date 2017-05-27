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

    public partial class Form4 : Form
    {

        public static Image slika;
        int brojac;


        public Form4()
        {
            InitializeComponent();
            PictureBox pic = new PictureBox();
            pic.Image = slika;
            pic.Width = 400;
            pic.Height = 400;
            this.panel1.Controls.Add(pic);
            brojac = 5;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (brojac > 0) { 
            brojac--;
            timerForHelp.Text = brojac + " секунди";
            if(brojac==0)
                this.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        { }
        
    }
}

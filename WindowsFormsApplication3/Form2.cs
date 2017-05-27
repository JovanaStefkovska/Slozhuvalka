using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Napreden : Form
    {
        
        int sekundi = 0;
        int flagTimer = 1;
        int obidiPomos = 5;
        int canPlay = 1;
        int krajIgra = 0;
        public static String ime = Wlc.ImeIgrac;
        public static Image slika = Wlc.Basic;
        public static Image help;

        public Napreden()
        {
            InitializeComponent();
            Prazna.X = 321;
            Prazna.Y = 321;
            help = Resize(slika);
            Form4.slika = help;
            postaviSlikichki(Sechenje(Resize(slika), 100, 100));
        }
        Point Prazna;
        private void Form2_Load(object sender, EventArgs e)
        {
            //postaviSlikichki(Sechenje(Resize(slika), 100, 100));
        }
        private void button17_Click(object sender, EventArgs e)         // btn pomos
        {
            if (obidiPomos > 0)
            {
                Form4 dialog = new Form4();
                dialog.ShowDialog();
                obidiPomos--;
                labelForHelp.Text = obidiPomos.ToString();
            }
            else
            {
                MessageBox.Show("Немате повеќе обиди за помош!");
            }
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        
        private void btns_Click(object sender, EventArgs e)
        {
            if (canPlay == 1)
                Pomesti((Button)sender);
        }
        private void Pomesti(Button kopche)
        {
            int x = Prazna.X - kopche.Location.X;
            int px = x < 0 ? -x : x;

            int y = Prazna.Y - kopche.Location.Y;
            int py = y < 0 ? -y : y;
            //moving right &left
            if (kopche.Location.Y.Equals(Prazna.Y) && px.Equals(kopche.Size.Width + 6))
            {

                kopche.Location = new Point(kopche.Location.X + x, kopche.Location.Y);
                Prazna.X -= x;


            }
            //moving top &bottom
            if (kopche.Location.X.Equals(Prazna.X) && py.Equals(kopche.Size.Width + 6))
            {
                kopche.Location = new Point(kopche.Location.X, kopche.Location.Y + y);
                Prazna.Y -= y;
            }
        }

        private Bitmap Resize(Image img)
        {   int w = 400;
            int h = 400;

            //create a new Bitmap the size of the new image
            Bitmap bmp = new Bitmap(w, h);
            //create a new graphic from the Bitmap
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //draw the newly resized image
            graphic.DrawImage(img, 0, 0, w, h);
            //dispose and free up the resources
            graphic.Dispose();
            //return the image
            return bmp;
        }

        public ArrayList Sechenje(Bitmap ToBeCropped, int x, int y)
        {
            ArrayList parchinja = new ArrayList();
            int desno = 0;
            int dole = 0;
            for (int n = 0; n < 15; n++)
            {
                Bitmap slikichka = new Bitmap(x, y);
                for (int i = 0; i < x; i++)
                   for (int j = 0; j < y; j++)
                        slikichka.SetPixel(i, j, ToBeCropped.GetPixel(i + desno, j + dole));

                parchinja.Add(slikichka);
                desno += 100;
                if (desno == 400) { desno = 0; dole += 100; }
                if (dole == 400) { break; }
            }
            return parchinja;
        }

        public void postaviSlikichki(ArrayList pieces)
        {
            int x = 0;
            int[] c = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Shuffle(c);
            foreach (Button b in containerNapredno.Controls)
            {
                if (x < c.Length)
                {
                    b.Image = (Image)pieces[c[x]];
                    x++;
                }
            }
        }

        private int[] Shuffle(int[] array)
        {
            Random r = new Random();
            int start = r.Next(1, array.Length);
            for (int i = 0; i < array.Length; i++)
                for (int j = start; j > 0; j--)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            int x = 0;
            foreach (Button b in containerNapredno.Controls)
            {
                b.ImageKey = "slika" + array[x].ToString();
                x++;
            }
            return array;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flagTimer == 1)
            {
                sekundi++;
                if (sekundi == 1)
                    timerNapredno.Text = sekundi.ToString() + " секундa.";
                else
                    timerNapredno.Text = sekundi.ToString() + " секунди.";
            }
        }

        private void btnKraj_Click(object sender, EventArgs e)
        {
            flagTimer = 0;
            foreach (Button b in containerNapredno.Controls)
            {
                if (b.ImageKey.Equals("slika0"))
                    if (b.Location.ToString().Equals("{X=3,Y=3}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika1"))
                    if (b.Location.ToString().Equals("{X=109,Y=3}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika2"))
                    if (b.Location.ToString().Equals("{X=215,Y=3}"))
                        krajIgra++;


                if (b.ImageKey.Equals("slika3"))
                    if (b.Location.ToString().Equals("{X=321,Y=3}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika4"))
                    if (b.Location.ToString().Equals("{X=3,Y=109}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika5"))
                    if (b.Location.ToString().Equals("{X=109,Y=109}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika6"))
                    if (b.Location.ToString().Equals("{X=215,Y=109}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika7"))
                    if (b.Location.ToString().Equals("{X=321,Y=109}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika8"))
                    if (b.Location.ToString().Equals("{X=3,Y=215}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika9"))
                    if (b.Location.ToString().Equals("{X=109,Y=215}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika10"))
                    if (b.Location.ToString().Equals("{X=215,Y=215}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika11"))
                    if (b.Location.ToString().Equals("{X=321,Y=215}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika12"))
                    if (b.Location.ToString().Equals("{X=3,Y=321}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika13"))
                    if (b.Location.ToString().Equals("{X=109,Y=321}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika14"))
                    if (b.Location.ToString().Equals("{X=215,Y=321}"))
                        krajIgra++;

            }

            if (krajIgra == 8)
            {
               DialogResult dialog = MessageBox.Show("Браво " + ime + " ја завршивте играта за " + sekundi + " секунди. Дали сакате нова игра?","Крај на играта", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.No)
                Close();
                else if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    Wlc prozorec = new Wlc();
                    prozorec.ShowDialog();
                }
            }
            else
            {
               DialogResult dialog = MessageBox.Show( ime + " Само "+ krajIgra+ " полиња Ви се на точно место. Дали сакате да започнете нова игра ?","Крај на играта", MessageBoxButtons.YesNoCancel);
                if(dialog == DialogResult.Yes)
                {
                    this.Hide();
                    Wlc prozorec = new Wlc();
                    prozorec.ShowDialog();
                }
                else if(dialog == DialogResult.No)  Close();
                       
                krajIgra = 0;
                flagTimer = 1;
            }
          

        }

        private void btnPauza_Click(object sender, EventArgs e)
        {
            if (flagTimer == 1)
            {
                btnPauza.Text = "Продолжи";
                canPlay = 0;
                flagTimer = 0;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;


            }
            else
            {
                btnPauza.Text = "Пауза";
                flagTimer = 1;
                canPlay = 1;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
            }
        }
    }
}

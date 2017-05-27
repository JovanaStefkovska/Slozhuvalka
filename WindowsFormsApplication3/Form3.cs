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
    public partial class Pocetnik : Form
    {
        int sekundi = 0;
        int flagTimer = 1;
        int obidiPomos = 5;
        int canPlay = 1;
        int krajIgra = 0;
        String ime = Wlc.ImeIgrac;
        public static Image slika = Wlc.Basic;
        public static Image help;

        public Pocetnik()
        {
            InitializeComponent();
            Prazna.X = 289;
            Prazna.Y = 289;
            help = Resize(slika);
            Form4.slika = help;
            postaviSlikichki(Sechenje(Resize(slika), 133, 133));
        }
        Point Prazna;
        private void Pocetnik_Load(object sender, EventArgs e)
        {

        }

        private void btns_Click0(object sender, EventArgs e)
        {
            if(canPlay==1)
            Pomesti0((Button)sender);
        }

        private void Pomesti0(Button kopche)
        {
            int x = Prazna.X - kopche.Location.X;
            int px = x < 0 ? -x : x;

            int y = Prazna.Y - kopche.Location.Y;
            int py = y < 0 ? -y : y;
            //moving right &left
            if (kopche.Location.Y.Equals(Prazna.Y) && px.Equals(kopche.Size.Width + 10))
            {

                kopche.Location = new Point(kopche.Location.X + x, kopche.Location.Y);
                Prazna.X -= x;


            }
            //moving top &bottom
            if (kopche.Location.X.Equals(Prazna.X) && py.Equals(kopche.Size.Width + 10))
            {
                kopche.Location = new Point(kopche.Location.X, kopche.Location.Y + y);
                Prazna.Y -= y;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            flagTimer = 0;
            foreach (Button b in containerPocetnik.Controls)
            {
                if (b.ImageKey.Equals("slika0"))
                    if (b.Location.ToString().Equals("{X=3,Y=3}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika1"))
                    if (b.Location.ToString().Equals("{X=146,Y=3}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika2"))
                    if (b.Location.ToString().Equals("{X=289,Y=3}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika3"))
                    if (b.Location.ToString().Equals("{X=3,Y=146}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika4"))
                    if (b.Location.ToString().Equals("{X=146,Y=146}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika5"))
                    if (b.Location.ToString().Equals("{X=289,Y=146}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika6"))
                    if (b.Location.ToString().Equals("{X=3,Y=289}"))
                        krajIgra++;

                if (b.ImageKey.Equals("slika7"))
                    if (b.Location.ToString().Equals("{X=146,Y=289}"))
                        krajIgra++;

            }

            if (krajIgra == 8)
            {
                MessageBox.Show("Успешно ја завршивте играта");
                Close();
            }
            else
            {
                MessageBox.Show("Само " + krajIgra + " полиња ви се на исто место");
                krajIgra = 0;
                flagTimer = 1;
            }
           // MessageBox.Show("Браво " + ime + " ја завршивте играта за " + sekundi + " секунди");          
            Igraci igrac = new Igraci(ime, sekundi);
           // Close();
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flagTimer==1) { 
            sekundi++;
            if(sekundi == 1)
                timerLabel.Text = sekundi.ToString() + " секундa.";
            else
            timerLabel.Text = sekundi.ToString() + " секунди.";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (obidiPomos > 0) {
                Form4 dialog = new Form4();
                dialog.ShowDialog();
            obidiPomos--;
            obidiLabel.Text = obidiPomos.ToString();
            }
            else
            {
                MessageBox.Show("Немате повеќе обиди за помош!");
            }

        }

        private void button18_Click(object sender, EventArgs e)       // btn pauza
        {
            if (flagTimer == 1)
            {
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

            }
            else
            {
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
            }
                
        }


        private Bitmap Resize(Image img)
        {
            int w = 400;
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
            for (int n = 0; n < 8; n++)
            {
                Bitmap slikichka = new Bitmap(x, y);
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                        slikichka.SetPixel(i, j, ToBeCropped.GetPixel(i + desno, j + dole));

                parchinja.Add(slikichka);
                desno += 133;
                if (desno == 399) { desno = 0; dole += 133; }
                if (dole == 399) { break; }
            }
            return parchinja;
        }

        public void postaviSlikichki(ArrayList pieces)
        {
            int x = 0;
            int[] c = new int[] { 7, 6, 5, 4, 3, 2, 1, 0 };
            Shuffle(c);
            foreach (Button b in containerPocetnik.Controls)
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
            foreach (Button b in containerPocetnik.Controls)
            {    
                b.ImageKey = "slika" + array[x].ToString();
                x++;
            }
            /*button1.Name = array[7].ToString();
              button2.Name = array[6].ToString();
              button3.Name = array[5].ToString();
              button4.Name = array[4].ToString();
              button5.Name = array[3].ToString();
              button6.Name = array[2].ToString();
              button7.Name = array[1].ToString();
              button8.Name = array[0].ToString();*/
            return array;
        }
    }
}

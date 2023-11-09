using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace PONG3
{
    public partial class Form1 : Form
    {
        List<pallina> listBall;
        List<padella> listPadelle;
        List<tasti> coppieTasti;
        Bitmap immagine;
        int punteggioA = 0, punteggioB = 0;
        int nA;
        int nB;

        class tasti
        {
            public Keys Up;
            public Keys Down;
        }
        class pallina
        {
            public int x, y;
            public int xDir, yDir;
            public int dim;
            public Color colore;
            public int v;  // velocità
        }
        class padella
        {
            public int x, y;
            public int lunghezza, larghezza;
            public int v;
            public tasti? t;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            immagine = new Bitmap(this.Width, this.Height);
            listaTasti();
            textBoxGiocatori.Text = "2";
            textBoxPalline.Text = "1";
            disegnaMetaCampo();
            pictureBoxCampo.Image = immagine;
        }

        private void listaTasti()
        {
            coppieTasti = new List<tasti>();
            coppieTasti.Add(new tasti { Up = Keys.Q, Down = Keys.A });
            coppieTasti.Add(new tasti { Up = Keys.W, Down = Keys.S });
            coppieTasti.Add(new tasti { Up = Keys.O, Down = Keys.L });
            coppieTasti.Add(new tasti { Up = Keys.I, Down = Keys.K });
            coppieTasti.Add(new tasti { Up = Keys.D1, Down = Keys.D2 });
        }
        private void drawPadella(padella p, Color c)
        {
            for (int h = 0; h < p.lunghezza; h++)
            {
                for (int w = -p.larghezza / 2; w < p.larghezza / 2; w++)
                {
                    padella z = tosaCoordinatePadella(p);
                    immagine.SetPixel(z.x + w, z.y + h, c);
                }
            }
            pictureBoxCampo.Image = immagine;
        }

        private pallina tosaCoordinatePallina(pallina p)
        {
            if (p.x <= (p.dim / 2)) p.x = (p.dim / 2);
            if (p.y <= (p.dim / 2)) p.y = (p.dim / 2);
            if (p.x > pictureBoxCampo.Width - 1 - (p.dim / 2)) p.x = pictureBoxCampo.Width - 1 - (p.dim / 2);
            if (p.y > pictureBoxCampo.Height - 1 - (p.dim / 2)) p.y = pictureBoxCampo.Height - 1 - (p.dim / 2);
            return p;
        }

        private padella tosaCoordinatePadella(padella p)
        {
            if (p.x <= 0) p.x = 0;
            if (p.y <= 0) p.y = 0;
            if (p.x > pictureBoxCampo.Width - 1) p.x = pictureBoxCampo.Width - 1;
            if (p.y > pictureBoxCampo.Height - 1 - p.lunghezza) p.y = pictureBoxCampo.Height - 1 - p.lunghezza;
            return p;
        }

        private void instanziaPadelle(int n)
        {
            Random rnd = new Random();
            listPadelle = new List<padella>();

            nA = n / 2;
            nB = n - nA;

            int sicurezza = 40;

            int metaCampo = pictureBoxCampo.Width / 2;

            int i = 0;
            if (nA > 0)
            {
                int distanzaA = (metaCampo - sicurezza) / nA;
                for (i = 0; i < nA; i++)
                {
                    int l = 100;
                    listPadelle.Add(new padella
                    {
                        lunghezza = l,
                        y = rnd.Next(0, pictureBoxCampo.Height - l),
                        larghezza = 3, //rnd.Next(3, 5),
                        x = sicurezza + i * distanzaA,
                        t = coppieTasti[i]
                    });
                }
            }
            if (nB > 0)
            {
                int distanzaB = (metaCampo - sicurezza) / nB;
                for (int j = 0; j < nB; j++)
                {
                    int l = 100;
                    listPadelle.Add(new padella
                    {
                        lunghezza = l,
                        y = rnd.Next(0, pictureBoxCampo.Height - l),
                        larghezza = rnd.Next(3, 5),
                        x = pictureBoxCampo.Width - sicurezza - j * distanzaB,
                        t = coppieTasti[j + i]
                    });
                }
            }
        }

        private void debugPallina(pallina p)
        {
            textBoxX.Text = p.x.ToString();
            textBoxY.Text = p.y.ToString();
            textBoxXDir.Text = p.xDir.ToString();
            textBoxYDir.Text = p.yDir.ToString();
            textBoxDim.Text = p.dim.ToString();
            textBoxColore.Text = p.colore.ToString();
        }

        private void instanziaPalline(int n)
        {
            Random rnd = new Random();
            listBall = new List<pallina>();

            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {                
                    listBall.Add(new pallina
                    {
                        colore = Color.Black,
                        x = rnd.Next(10, pictureBoxCampo.Width - 1),
                        y = rnd.Next(10, pictureBoxCampo.Height - 1),
                        xDir = generaDirezioneCasuale(),
                        yDir = generaDirezioneCasuale(),
                        dim = 7,//rnd.Next(1, 10),
                        v = rnd.Next(1, 2)
                    });
                }
            }
        }

        private void drawPallina(pallina p, Color c)
        {
            debugPallina(p);
            int x, y;
            for (int i = -p.dim / 2; i < p.dim / 2; i++)
            {
                for (int j = -p.dim / 2; j < p.dim / 2; j++)
                {
                    x = p.x + i;
                    if (x < p.dim / 2) x = p.dim / 2;
                    if (x > pictureBoxCampo.Width - 1 - p.dim / 2)
                        x = pictureBoxCampo.Width - 1 - p.dim / 2;
                    y = p.y + j;
                    if (y < p.dim / 2) y = p.dim / 2;
                    if (y > pictureBoxCampo.Height - 1 - p.dim / 2)
                        y = pictureBoxCampo.Height - 1 - p.dim / 2;
                    immagine.SetPixel(x, y, c);
                }
            }
            pictureBoxCampo.Image = immagine;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (pallina p in listBall)
            {
                drawPallina(p, Color.White);
                p.x += p.xDir / p.v;
                p.y += p.yDir / p.v;
                pallina z;
                z = checkConfineBall(p);
                z = checkCollision(z);
                drawPallina(z, z.colore);
            }

            foreach (padella p in listPadelle)
            {
                drawPadella(p, Color.White);

                padella z;
                z = checkConfinePadella(p);
                drawPadella(z, Color.Black);
            }

            disegnaMetaCampo();

            labelPunteggioA.Text = punteggioA.ToString();
            labelPunteggioB.Text = punteggioB.ToString();
        }

        private void disegnaMetaCampo()
        {
            int x = pictureBoxCampo.Width / 2;

            for (int y = 0; y < pictureBoxCampo.Height; y++)
            {                
                immagine.SetPixel(x, y,
                    (y / 20) % 2 == 0 ? Color.Black : Color.White);
            }
            pictureBoxCampo.Image = immagine;
        }
        private pallina checkCollision(pallina p)
        {
            foreach (padella padella in listPadelle)
            {
                if (
                        (
                            p.x >= (padella.x - Math.Abs(p.xDir / 2)) &&
                            p.x <= (padella.x + Math.Abs(p.xDir / 2) + (padella.larghezza / 2))
                        ) &&
                        (
                            p.y >= padella.y &&
                            p.y < (padella.y + padella.lunghezza)
                        )
                    )
                {
                    int d = (padella.x + (padella.lunghezza / 2) - p.x) / 10;
                    if (d == 0) d = 1;
                    p.xDir = p.xDir > 0 ? -d : d;                    
                }
            }
            return p;
        }

        private padella checkConfinePadella(padella p)
        {
            if (p.y <= 4) p.y = 4;
            if (p.y > pictureBoxCampo.Height - p.lunghezza) p.y = pictureBoxCampo.Height - p.lunghezza;
            return p;
        }

        private pallina checkConfineBall(pallina p)
        {
            if (p.x <= p.dim / 2 || p.x >= pictureBoxCampo.Width - 1 - (p.dim / 2))
            {
                Random rnd = new Random();
                p.xDir *= (-1);
                if (p.x < pictureBoxCampo.Width / 2)
                {
                    punteggioB++;
                    int newPadella = rnd.Next(0, nB - 1);
                    p.x = listPadelle[nA + newPadella].x - listPadelle[nA + newPadella].larghezza;
                    p.y = listPadelle[nA + newPadella].y + listPadelle[nA + newPadella].lunghezza / 2;
                    p.xDir = generaDirezioneCasuale();
                    p.yDir = generaDirezioneCasuale();
                }
                else
                {
                    punteggioA++;
                    int newPadella = rnd.Next(0, nA - 1);
                    p.x = listPadelle[newPadella].x + listPadelle[newPadella].larghezza;
                    p.y = listPadelle[newPadella].y + listPadelle[newPadella].lunghezza / 2;
                    p.xDir = generaDirezioneCasuale();
                    p.yDir = generaDirezioneCasuale();
                }
                //changeRun();
            }

            if (p.y <= p.dim / 2 || p.y >= pictureBoxCampo.Height - 1 - (p.dim / 2))
            {
                p.yDir *= (-1);
            }

            return p;
        }

        private int generaDirezioneCasuale()
        {
            Random rnd = new Random();
            int z;
            do
                z = rnd.Next(-5, 5);
            while (z == 0);

            return z;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            clearImage(immagine);
            instanziaPalline(Convert.ToInt32(textBoxPalline.Text));
            instanziaPadelle(Convert.ToInt32(textBoxGiocatori.Text));

            foreach (pallina p in listBall)
            {
                drawPallina(p, p.colore);
            }

            foreach (padella p in listPadelle)
            {
                drawPadella(p, Color.Black);
            }
            disegnaMetaCampo();
        }

        private void clearImage(Bitmap bmp)
        {
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    bmp.SetPixel(x, y, Color.White);
                }
            }
            pictureBoxCampo.Image = bmp;
            immagine = bmp;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            changeRun();
        }

        private void changeRun()
        {

            if (timer1.Enabled == false)
            {
                buttonRun.Text = "Stop";
                timer1.Enabled = true;
                this.KeyPreview = true;
            }
            else
            {
                buttonRun.Text = "Run";
                timer1.Enabled = false;
                this.KeyPreview = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());

            foreach (padella p in listPadelle)
            {
                drawPadella(p, Color.White);
                textBoxKey.Text = e.KeyCode.ToString();

                if (e.KeyCode == p.t.Up) p.y -= 10;
                if (e.KeyCode == p.t.Down) p.y += 10;

                drawPadella(p, Color.Black);
            }

        }

        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BotsbalGame
{
    public partial class Form1 : Form
    {
        private int snelheidLinks = 10;
        private int snelheidTop = 10;

        private int scoreCPU = 0;
        private int scoreSpeler = 0;

        private Random rndRGB = new Random();
        private Random rndLatenWinnen = new Random();

        public Form1()
        {
            InitializeComponent();

            timer.Start();
            Cursor.Hide();
            FormBorderStyle = FormBorderStyle.None; //geen "boders", grenzen, randen (zoals bv. 'snelmenu')
            TopMost = true; //frm naar voorgrond
            Bounds = Screen.PrimaryScreen.Bounds; //fullscreen
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //cursor laat pictBoxSpeler bewegen (op en neer)
            pictBoxSpeler.Top = Cursor.Position.Y / 2;

            //bal laten bewegen en weerkaatsen als het de top/bodem raakt
            pictBoxBal.Left += snelheidLinks;
            pictBoxBal.Top += snelheidTop;

            if (pictBoxBal.Top <= panelSpeelveld.Top || pictBoxBal.Bottom >= panelSpeelveld.Bottom)
            {
                snelheidTop = -snelheidTop;
            }

            //AI (= CPU) laten meespelen
            if (rndLatenWinnen.Next(50) < 25)
            {
                while (pictBoxBal.Top < pictBoxCPU.Top)
                {
                    pictBoxCPU.Top--;
                }

                while (pictBoxBal.Bottom > pictBoxCPU.Bottom)
                {
                    pictBoxCPU.Top++;
                }
            }

            //bal terugkaatsen indien ie een pictBox raakt en evt. (bij < 20) versnellen
            if (pictBoxBal.Right >= pictBoxSpeler.Left && pictBoxBal.Top >= pictBoxSpeler.Top && pictBoxBal.Bottom <= pictBoxSpeler.Bottom
               || pictBoxBal.Left <= pictBoxCPU.Right && pictBoxBal.Top >= pictBoxCPU.Top && pictBoxBal.Bottom <= pictBoxCPU.Bottom)
            {
                snelheidLinks = -snelheidLinks;

                if (snelheidLinks < 20)
                {
                    snelheidLinks++;
                }
            }

            //als pictBoxBal uit panelSpeelveld is, moet er een pt worden bijgeteld en de bal opnieuw verschijnen in panelSpeelveld (in het midden)
            //en snelheidLinks wordt gereset
            if (pictBoxBal.Right >= panelSpeelveld.Right)
            {
                scoreCPU++;
                panelSpeelveld.BackColor = Color.FromArgb(rndRGB.Next(0, 255), rndRGB.Next(10, 255), rndRGB.Next(10, 255));
                snelheidLinks = 10;
                pictBoxBal.Top = panelSpeelveld.Bottom / 2;
                pictBoxBal.Left = panelSpeelveld.Right / 2;
            }

            if (pictBoxBal.Left <= panelSpeelveld.Left)
            {
                scoreSpeler++;
                panelSpeelveld.BackColor = Color.FromArgb(rndRGB.Next(0, 255), rndRGB.Next(10, 255), rndRGB.Next(10, 255));
                snelheidLinks = 10;
                pictBoxBal.Top = panelSpeelveld.Bottom / 2;
                pictBoxBal.Left = panelSpeelveld.Right / 2;
            }

            //geüpdatete score verschijnt op het scherm
            lblScore.Text = scoreCPU + " - " + scoreSpeler;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Esc om af te sluiten (de uitslag verschijnt nog)
            if (e.KeyCode == Keys.Escape)
            {
                if (scoreSpeler > scoreCPU)
                {
                    MessageBox.Show("U heeft gewonnen: " + lblScore.Text);
                }
                else if (scoreCPU > scoreSpeler)
                {
                    MessageBox.Show("Game over: " + lblScore.Text);
                }
                else
                {
                    MessageBox.Show("beiden even sterk/zwak: " + lblScore.Text);
                }

                Close();
            }

            ////pijltje naar beneden om pictBoxSpeler naar beneden te verplaatsen
            //if (e.KeyCode == Keys.Down)
            //{
            //    pictBoxSpeler.Top += 40;
            //}


            ////pijltje naar boven om pictBoxSpeler naar boven te verplaatsen
            //if (e.KeyCode == Keys.Up)
            //{
            //    pictBoxSpeler.Top -= 40;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectgomoku
{
    public partial class GoMoKu : Form
    {
        public GoMoKu()
        {
            InitializeComponent();
        }
        public Button[,] tombol = new Button[15, 15];
        public string nama;

        public int sumbux;
        public int sumbuy;
        public int player = 0;
        public int cek = 0;
        public int count = 0;
        public string[,] nitip = new string[15, 15];
        
        public string simbol;
        public int pemenang = 0;
        
        public int batas;
        public string namaplayer1;
        public string namaplayer2;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    tombol[i, j] = new Button();
                    tombol[i, j].BringToFront();
                    nama = i.ToString() + ',' + j.ToString();
                    tombol[i, j].Name = nama;

                    tombol[i, j].Size = new Size(20, 20);
                    tombol[i, j].Location = new Point(26 + (i * 20), 105 + (j * 20));
                    this.Controls.Add(tombol[i, j]);
                    tombol[i, j].Click += new EventHandler(pencet_click);
                    // tombol[i, j].Visible = true;
                    tombol[i, j].FlatStyle = FlatStyle.Flat;
                    tombol[i, j].FlatAppearance.BorderSize = 0;
                    tombol[i, j].FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
                    tombol[i, j].TabStop = false;

                    tombol[i, j].BackColor = Color.Transparent;

                }
            }
        }
        
        private void pencet_click(object sender, EventArgs e)
        {
            var x = sender as Button;

            sumbux = Convert.ToInt32(Convert.ToString(x.Name.Substring(0, x.Name.IndexOf(',')))); 
            sumbuy = Convert.ToInt32(Convert.ToString(x.Name.Substring(x.Name.IndexOf(',') + 1, x.Name.Length - x.Name.IndexOf(',') - 1)));

            if (player == 0)
            {
                //tombol[sumbux, sumbuy].BackgroundImage = Image.FromFile(@"C: \Users\prava\source\repos\projectgomoku\bulet hitam.jpg");
                tombol[sumbux, sumbuy].BackColor = Color.Black;
                simbol = "x";
                player = 1;
                cek++;

            }
            else if (player == 1)
            {
                tombol[sumbux, sumbuy].BackColor = Color.White;
                simbol = "o";
                player = 0;
                cek++;
            }
            tombol[sumbux, sumbuy].Enabled = false;
            nitip[sumbux, sumbuy] = simbol;
            if (cek == 225)
            {

               
                this.Hide();
                Form2 ob = new Form2();
                ob.Show();

            }
            if (menang(sumbux, sumbuy, player) == true)
            {
                pemenang = 1;
            }

            // for(int i = 0; i < 5; i++)
            //{
            // for(int j = 0; j < 5; j++)
            //{
            //if(tombol[i, j].BackColor == tombol[i + 1, j].BackColor && tombol[i + 1, j].BackColor == tombol[i + 2, j].BackColor && tombol[i + 2, j].BackColor == tombol[i + 3, j].BackColor && tombol[i + 3, j].BackColor == tombol[i + 4, j].BackColor)
            //{
            //pemenang = 1;

            //}                   
            // }

            //}
            namaplayer1 = playername1.Text;
            namaplayer2 = playername2.Text;
            if (pemenang == 1)
            {
                if(player == 0)
                {
                    MessageBox.Show("Congratulations " + namaplayer1 + " you win !");
                    this.Hide();
                    winner ab = new winner();
                    ab.Show();
                }
                else if (player == 1)
                {
                    MessageBox.Show("Congratulations " + namaplayer2 + " you win !");
                    this.Hide();
                    winner ab = new winner();
                    ab.Show();
                }
            }

        }
        public Boolean menang(int sumbux, int sumbuy, int player)
        {

            int poin = 0;
            int serongy, serongx;
            int batas;
            string simbol;
            if(player == 0)
            {
                simbol = "o";
            }
            else
            {
                simbol = "x";
            }
            //check vertical
            for (int z = 0; z < 15; z++)
            {
               
                if (nitip[sumbux, z]  != simbol)
                {
                    poin = 0;
                }
                else
                {
                    poin++;
                }
                
            }
            if (poin == 5)
            {
                return true;
            }
            poin = 0;
            //check horizontal
            for (int z = 0; z < 15; z++)
            {
                
                if (nitip[z, sumbuy] != simbol)
                {
                    poin = 0;
                }
                else
                {
                    poin++;
                }
                if (poin == 5)
                {
                    return true;
                }
            }
            poin = 0;

            //check serong kanan
            //x
            //  x
            //    x
            poin = 1;
            for(int z = 1;z<5; z++)
            {
                if (sumbux + z <= 14 && sumbuy + z <= 14)
                {
                    if (nitip[sumbux + z, sumbuy + z] != simbol)
                    {
                        break;
                    }
                    else
                    {
                        poin++;
                    }
                }
                
            }
            for (int j = 1; j < 5; j++)
            {

                if (sumbux - j >= 0 && sumbuy - j >= 0 )
                {
                    if (nitip[sumbux - j, sumbuy - j] != simbol)
                    {
                        break;
                    }
                    else
                    {
                        poin++;
                    }
                }


            }
           
            if (poin == 5)
            {
                return true;
            }
            poin = 0;
            //if (sumbuy >= sumbux)
            //{
            //    serongx = 0;
            //    serongy = sumbux - sumbuy;
            //    while (serongy < 15)
            //    {
            //        poin++;
            //        if (nitip[serongx, serongy] !=simbol)
            //        {
            //            poin = 0;
            //        }
            //        if (poin == 5)
            //        {
            //            return true;
            //        }
            //        serongx++;
            //        serongy++;
            //    }
            //}
            //else if (sumbuy < sumbux)
            //{
            //    serongy = 0;
            //    serongx = sumbux - sumbuy;
            //    while (serongx < 15)
            //    {
            //        poin++;
            //        if (nitip[serongx, serongy] != simbol)
            //        {
            //            poin = 0;
            //        }
            //        if (poin == 5)
            //        {
            //            return true;
            //        }
            //        serongx++;
            //        serongy++;
            //    }
            //}
            ////check serong kiri
            ////    x
            ////  x
            ////x
            poin = 1;
            for (int z = 1; z < 5; z++)
            {
                if (sumbux + z <= 14 && sumbuy - z >= 0)
                {
                    if (nitip[sumbux + z, sumbuy - z] != simbol)
                    {
                        break;
                    }
                    else
                    {
                        poin++;
                    } 
                }

            }
            for (int j = 1; j < 5; j++)
            {

                if (sumbux - j >= 0 && sumbuy + j <= 14)
                {
                    if (nitip[sumbux - j, sumbuy + j] != simbol)
                    {
                        break;
                    }
                    else
                    {
                        poin++;
                    }
                }


            }

            if (poin == 5)
            {
                return true;
            }
            poin = 0;
            //poin = 1;
            //if (sumbuy > 0) 
            //{
            //    for (int z = 1; z < 5; z++)
            //    {
            //        if (nitip[sumbux + z, sumbuy - z] == simbol)
            //        {
            //            poin++;
            //        }
            //        else
            //        {
            //            break;
            //        }

            //    }
            //}
            //if (sumbux > 0)
            //{
            //    for (int j = 1; j < 5; j++)
            //    {
            //        if (nitip[sumbux - j, sumbuy + j] == simbol)
            //        {
            //            poin++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}
            //if (poin == 5)
            //{
            //    return true;
            //}
            //serongx = sumbuy + sumbux;

            //if (serongx > 14)
            //{
            //    serongy = serongx - 14 ;
            //    serongx = 14;
            //}
            //else
            //{
            //    serongy = 0;
            //}
            //batas = serongx;

            //while (serongy != batas)
            //{
            //    poin++;
            //    if (nitip[serongx, serongy] != simbol)
            //    {
            //        poin = 0;
            //    }
            //    if (poin == 5)
            //    {
            //        return true;
            //    }
            //    serongy++;
            //    serongx--;
            //}

            return false;
        }


    }

}

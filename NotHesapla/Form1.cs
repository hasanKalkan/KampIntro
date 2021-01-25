using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace NotHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            /* int left = 100; int top = 200;
             TextBox textBox = new TextBox();
             textBox.Left = left;
             textBox.Top = top;
             this.Controls.Add(textBox);*/

            /* TextBox[] textBoxes1 = new TextBox[2];
             textBoxes1[0] = new TextBox();
             textBoxes1[1] = new TextBox();
               textBoxes1[0].Top = 200;
             textBoxes1[0].Left = 100;
              textBoxes1[1].Top = 250;
             textBoxes1[1].Left = 100;
             textBoxes1[0].Enabled = false;
             this.Controls.Add(textBoxes1[0]);            
             this.Controls.Add(textBoxes1[1]);*/


            textBoxEkle();        
        }

        public void textBoxEkle()
        {
            int i = int.Parse(txtDersAdedi.Text);
            label1.Text = i.ToString();
            int top = 50;
            TextBox[] textBoxes = new TextBox[i];
            for (int j = 0; j < i; j++)
            {
                textBoxes[j] = new TextBox();
                // textBoxes[j].Width = 100;
                //textBoxes[j].Height = 40;
                textBoxes[j].Left = 100;
                textBoxes[j].Top = top;
                this.Controls.Add(textBoxes[j]);
                top += 30;
            }
            int toplam = 0;
         /*   public static void ortalamaHesapla()
            {
                
            }*/
        }

        private void btnOrtalamaHesapla_Click(object sender, EventArgs e)
        {
            //textBoxEkle(orta)
        }
        int dersSayisi = 0;
        private void btnDersArttir_Click(object sender, EventArgs e)
        {

        }
    }
}

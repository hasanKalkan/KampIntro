using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* for (int i = 0; i < 64; i++) // butonlar üst üste biner.
             {
                 Button button = new Button();
                 button.Width = 50;
                 button.Height = 50;
                 //button.Text = "Ali";
                 this.Controls.Add(button);
             }*/

            //Button[] buttons = new Button[64];  
            GenerateButtons();

        }

        private void GenerateButtons() // Ctrl tuşu ile birlikte . tuşuna bastık. Extract Metot dedik.
        {
            Button[,] buttons = new Button[8, 8];  //örneğin 2.satırın 4.sütunu
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //ilk 8 in  en büyük değeri-7
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++) //ikinci sekiz
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50; // her yeni buton eklendiğinde 50 sağa geçer.
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;  // ikinci satırda left 0 olur.
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dec_S__Bilgi_yarışması_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno, doğru, yanlış;

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonsonraki.Enabled = true;

            label5.Text = buttonB.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonsonraki.Enabled = true;

            label5.Text = buttonC.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonsonraki.Enabled = true;

            label5.Text = buttonD.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonsonraki.Enabled = true;

            label5.Text = buttonA.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonsonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblsoruno.Text = soruno.ToString();

            if (soruno == 0)
            {

                richTextBox1.Text = "Sonraki butonuna basıp yarışmaya başlayabilirsiniz";
            }

            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiye Süper Lig takımlarından hangisi 2000 yılında Arsenal takımını yenerek Uefa kupasını müzesine götürmüştür?";
                buttonA.Text = "Galatasaray";
                buttonB.Text = "Fenerbahçe";
                buttonC.Text = "Beşiktaş J.K.";
                buttonD.Text = "Trabzonspor";
                label4.Text = "Galatasaray";
            }

            if (soruno== 2)
            {
                richTextBox1.Text = "Cristiano Ronaldo aşağıdaki takımların hangisinde forma giymemiştir?";
                buttonA.Text = "Real Madrid";
                buttonB.Text = "Manchester United";
                buttonC.Text = "Sporting CP";
                buttonD.Text = "Bayern Munich";
                label4.Text = "Bayern Munich";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Radamel Falcao, Porto takımıyla hangi takıma karşı gol atıp takımının maçı 1-0 ile galip gelmesini sağlayarak Uefa kupasını kaldırmıştır?";
                buttonA.Text = "Chelsea";
                buttonB.Text = "Braga";
                buttonC.Text = "Sevilla";
                buttonD.Text = "Liverpool";
                label4.Text = "Braga";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Hangi futbolcu Barcelona takımında forma giymemiştir?";
                buttonA.Text = "Rüştü Reçber";
                buttonB.Text = "Samuel Eto'o";
                buttonC.Text = "Ronaldinho";
                buttonD.Text = "Roberto Carlos";
                label4.Text = "Roberto Carlos";
                

            }
            if (soruno == 5)
            {
                buttonsonraki.Text = "Sonuçlar";
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonsonraki.Enabled = false;
                MessageBox.Show("Doğru:" + doğru + "\n" + "Yanlış:" + yanlış);
                    
            }

        }
    }
}

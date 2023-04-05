namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        int secim = 0;
        double sayi1, sayi2, sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Buttonlar(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            // bir tane silme/geri alma iþlemini yaptým.
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
        //secimlerin hangi islem oldugunu atadým.
        private void buttonArti_Click(object sender, EventArgs e)
        {

            sayi1 = double.Parse(textBox1.Text);
            secim = 1;
            textBox1.Text = "0";
        }

        private void buttonEksi_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 2;
            textBox1.Text = "0";
        }

        private void buttonCarpi_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 3;
            textBox1.Text = "0";
        }

        private void buttonBolu_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            secim = 4;
            textBox1.Text = "0";
        }

        private void buttonEsittir_Click(object sender, EventArgs e)
        {
            //secimlerin hangi iþlemleri yapacaðýný kodladým.
            sayi2 = double.Parse(textBox1.Text);
            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
            }
            textBox1.Text = sonuc.ToString();

            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
            }
            textBox1.Text = sonuc.ToString();

            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
            }
            textBox1.Text = sonuc.ToString();

            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
            }
            textBox1.Text = sonuc.ToString();
        }

        private void buttonVirgul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") < 1)
            {
                textBox1.Text += ",";
            }
        }

        private void buttonNegatiflik_Click(object sender, EventArgs e)
        {
            // sayýyý negatif veya pozitif hale çevirdim.
            if (textBox1.Text != "0")
            {
                if (textBox1.Text.StartsWith("-"))
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                }
                else if (textBox1.Text.StartsWith(""))
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // açý deðerini aldým ve radyan cinsine çevirip sin ve cos degerlerini hesapladým.
            double angle = double.Parse(textBox1.Text);

            double radians = angle * Math.PI / 18;
            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);

            // MessageBox kullanarak sonuçlarý gösterdim.
            MessageBox.Show("Sinüs: " + sin.ToString() + "\n" + "Kosinüs: " + cos.ToString());
        }
    }
}
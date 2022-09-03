namespace faiz
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
  
        decimal faizoraný;
        decimal anapara;
        int gun;    

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lblsonuc.Text = "";
            lblsonuc2.Text = "";
            ayhesapla.Visible = false;
            yilhesapla.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "GÜN";
            gunhesapla.Visible = true;
            ayhesapla.Visible = false;
            yilhesapla.Visible = false;
            button1.BackColor = Color.MediumBlue;
            button2.BackColor = Color.RoyalBlue;
            button3.BackColor = Color.RoyalBlue;
            txtvd.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "AY";
            gunhesapla.Visible = false;
            yilhesapla.Visible = false;
            ayhesapla.Visible = true;
            button1.BackColor = Color.RoyalBlue;
            button2.BackColor = Color.MediumBlue;
            button3.BackColor = Color.RoyalBlue;
            txtvd.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "YIL";
            gunhesapla.Visible = false;
            ayhesapla.Visible = false;
            yilhesapla.Visible = true;
            button1.BackColor = Color.RoyalBlue;
            button2.BackColor = Color.RoyalBlue;
            button3.BackColor = Color.MediumBlue;
            txtvd.Text = "";
        }             
  
        private void gunhesapla_Click(object sender, EventArgs e)
        {
            anapara = Convert.ToDecimal(txtana.Text);
            faizoraný = Convert.ToDecimal(txtfz.Text);
            gun = Convert.ToInt32(txtvd.Text);
            decimal hesaplama = (anapara / 100) * (faizoraný / 365) * gun;
            hesaplama = Decimal.Round(hesaplama, 2);
            lblsonuc.Text = "Faiz mikarý: " + hesaplama.ToString() + " TL";
            decimal sonpara = hesaplama + anapara;
            sonpara = Decimal.Round(sonpara, 2);
            lblsonuc2.Text = "Vade sonu toplam: " + sonpara.ToString() + " TL";
        }

        private void yilhesapla_Click(object sender, EventArgs e)
        {
            anapara = Convert.ToDecimal(txtana.Text);
            faizoraný = Convert.ToDecimal(txtfz.Text);
            gun = Convert.ToInt32(txtvd.Text);
            decimal hesaplama = (anapara / 100) * (faizoraný) * gun;
            hesaplama = Decimal.Round(hesaplama, 2);
            lblsonuc.Text = "Faiz mikarý: " + hesaplama.ToString() + " TL";
            decimal sonpara = hesaplama + anapara;
            sonpara = Decimal.Round(sonpara, 2);
            lblsonuc2.Text = "Vade sonu toplam: " + sonpara.ToString() + " TL";
        }

        private void ayhesapla_Click(object sender, EventArgs e)
        {
            anapara = Convert.ToDecimal(txtana.Text);
            faizoraný = Convert.ToDecimal(txtfz.Text);
            gun = Convert.ToInt32(txtvd.Text);
            decimal hesaplama = (anapara / 100) * (faizoraný / 12) * gun;
            hesaplama = Decimal.Round(hesaplama, 2);
            lblsonuc.Text = "Faiz mikarý: " + hesaplama.ToString() + " TL";
            decimal sonpara = hesaplama + anapara;
            sonpara = Decimal.Round(sonpara, 2);
            lblsonuc2.Text = "Vade sonu toplam: " + sonpara.ToString() + " TL";
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            txtana.Text = "";
            txtfz.Text = "";
            txtvd.Text = "";
            lblsonuc.Text = "";
            lblsonuc2.Text = "";
        }
    }
}
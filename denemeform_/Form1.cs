using deneme_lib;

namespace denemeform_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 dnm= new Class1();
            dnm.adi = "Emiray";
            dnm.Toplama(10, 20);
            dnm.email_=email_txt.Text;
            dnm.cikarma(Convert.ToInt32(txt_s1.Text),Convert.ToInt32(txt_s2.Text));
            snc1.Text = dnm.sonuc2.ToString();
            snc.Text= dnm.sonuc1.ToString();
            ad.Text=dnm.adi.ToString();
            email.Text=dnm.email_;
        }
    }
}

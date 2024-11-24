using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace HesapMakinesiArayüz
{
    public partial class Form1 : Form
    {
        Double cevap = 0;
        bool sayivarmi = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonclick(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")

                textBox1.Clear();




            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            double.TryParse(textBox1.Text, out double deger);
            cevap = deger;
            sayivarmi = false;
        }
       

        private void operatorclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            if (sayivarmi == false)
            {


                textBox1.Text = textBox1.Text + button.Text;
                
                
                sayivarmi = true;

            }

        }

        private void clearclick(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
            hesapmakinesilabel.Text = "Hesap Makinesi";


        }
        
        private void buttonesittir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0/0")
            {
                hesapmakinesilabel.Text = "Tanımsız";
            }
            else
            {
                try
                {
                    
                    string islem = textBox1.Text;


                    var sonuc = new DataTable().Compute(islem, null);


                    hesapmakinesilabel.Text = sonuc.ToString();
                }
                catch
                {

                    hesapmakinesilabel.Text = "Hatalı işlem!";
                }
            }
        }
    }
}
namespace NogometniSusret
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            try { 
           var susret= new KontrolaSusreta().EvidentirajSusret(txtHost.Text,txtGuest.Text,txtResult.Text);
            MessageBox.Show(susret.Domacin.Naziv + " " + susret.BrojPogodakaDomacin + ":" + susret.BrojPogodakaGost + " " + susret.Gost.Naziv);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
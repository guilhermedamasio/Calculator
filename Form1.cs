using System.Data;
namespace calcApp
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            txtOut.Text = currentCalculation;
        }
        private void btn_Equals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString();
            try
            {
                txtOut.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation = txtOut.Text;
            }
            catch
            {
                txtOut.Text = "ERROR";
                currentCalculation = "";
            }
        }
    }
}

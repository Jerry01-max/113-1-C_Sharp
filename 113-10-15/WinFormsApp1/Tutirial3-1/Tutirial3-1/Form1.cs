namespace Tutirial3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string output;

            output = "����" + txtyear.Text + "�~" + txtmonth.Text + "��" + "�P��" + txtday.Text;

            lblshow.Text = output;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtweek.Text = "";
            txtmonth.Text = "";
            txtday.Text = "";
            txtyear.Text = "";
            lblshow.Text = "";
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
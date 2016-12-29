using System.Windows.Forms;

namespace GuysProject_ch3
{
    public partial class Form1 : Form
    {
        Guy joe;

        Guy bob;

        int bank = 100; 

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "Bank has $" + bank; 
        }

        private void joeButton_Click(object sender, System.EventArgs e)
        {
            if (bank >= 10)
            {
                joe.ReceiveCash(10);
                bank -= 10;
                UpdateForm(); 
            }
            else
            {
                NotEnoughMoneyError();
            }
        }

        private void bobButton_Click(object sender, System.EventArgs e)
        {
            if (bank >= 5)
            {
                bank -= bob.ReceiveCash(5);
                UpdateForm();
            }
            else
            {
                NotEnoughMoneyError();
            }
        }

        private void NotEnoughMoneyError()
        {
            MessageBox.Show("Not enough money in bank: " + bank);
        }
    }
}

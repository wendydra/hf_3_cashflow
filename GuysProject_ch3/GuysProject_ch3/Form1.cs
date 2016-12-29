using System.Windows.Forms;

namespace GuysProject_ch3
{
    public partial class Form1 : Form
    {
        //Q: Why do we declare these up here?
        //A: Because when you declare a variable inside a method, it is only valid inside that method.
        //It cannot be accessed from any other method. But when you declare it OUTSIDE a method but INSIDE a class
        //Then you have added a field accessible -from any other method- inside the form

        //Q: What if I put Guy joe = new Guy(); inside the Form1 method?
        //A: That is equivalent to declaring two variables, so the joe declared in here is never set to anything
        //One is only available in the method, other is avaialable throughout the entire form
        //You may get a NullReferenceException not handled error which just means you tried to use
        //an object before you created it with new.

        Guy joe;

        Guy bob;

        int bank = 100; 

        public Form1()
        {
            InitializeComponent();

            joe = new Guy();
            joe.Name = "Joe";
            joe.Cash = 30;

            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 10;

            UpdateForm();
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

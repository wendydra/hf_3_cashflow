using System.Windows.Forms;

namespace GuysProject_ch3
{
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            //Prompt was not clear in the beginning but the guys are not giving each other money in this problem
            //Instaed they are getting money from the bank
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(
                    "Not enough cash " + amount, Name + " says.");
                return 0;
            }
        }
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(
                    "That's negative!" + amount);
                return 0;
            }
        }
    }
}

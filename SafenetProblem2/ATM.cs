using System;
using System.Collections.Generic;
using System.Text;

namespace SafenetProblem2
{
    class ATM
    {
        private int hundred;
        private int fifty;
        private int twenty;
        private int tens;
        private int fives;
        private int ones;
        private int xMoney;

        public ATM()
        {
            hundred = 10;
            fifty = 10;
            twenty = 10;
            tens = 10;
            fives = 10;
            ones = 10;

        }

        public void refill()
        {
            hundred = 10;
            fifty = 10;
            twenty = 10;
            tens = 10;
            fives = 10;
            ones = 10;
            Console.WriteLine(this.toString());
        }

        public void take(int money)
        {
            if (this.getBalance() >= money)
            {
                Console.WriteLine("Success: Dispensed $" + money);
                xMoney = money;
                while (hundred > 0 && xMoney >= 100)
                {
                    xMoney -= 100;
                    hundred -= 1;
                }
                while (fifty > 0 && xMoney >= 50)
                {
                    xMoney -= 50;
                    fifty -= 1;
                }
                while (twenty > 0 && xMoney >= 20)
                {
                    xMoney -= 20;
                    twenty -= 1;
                }
                while (tens > 0 && xMoney >= 10)
                {
                    xMoney -= 10;
                    tens -= 1;
                }
                while (fives > 0 && xMoney >= 5)
                {
                    xMoney -= 5;
                    fives -= 1;
                }
                while (ones > 0 && xMoney >= 1)
                {
                    xMoney -= 1;
                    ones -= 1;
                }
                Console.WriteLine(this.toString());
            }
            else
            {
                Console.WriteLine("Failure: insufficient funds");
            }
        }

        public int getBalance()
        {
            return (hundred * 100 + fifty * 50 + twenty * 20 + tens * 10 + fives * 5 + ones);
        }

        public int getHundreds()
        {
            return hundred;
        }

        public int getFifty()
        {
            return fifty;
        }

        public int getTwenty()
        {
            return twenty;
        }

        public int getTens()
        {
            return tens;
        }

        public int getFives()
        {
            return fives;
        }

        public int getOnes()
        {
            return ones;
        }

        public String toString()
        {
            return ("Machine Balance: \n $100 - " + hundred + "\n $50 - " + fifty + "\n $20 - " + twenty + "\n $10 - "
                    + tens + "\n $5 - " + fives + "\n $1 - " + ones + "\n \n Balance: $" + this.getBalance());
        }

    }

}

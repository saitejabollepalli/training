using System;
using System.Collections.Generic;
using System.Text;

namespace ATMAssignment
{
    public class SBI1 :ATM
    {
			public virtual void withdraw(int accountNumber, double amount)
			{
				Console.WriteLine("your account Number of SBI  is : " + accountNumber);
				Console.WriteLine("the amount in your SBI bank is  : " + amount);
				if (amount <= 0)
				{
					throw new InvalidAmountException("Invalid amount; amount<=0");
				}
			}

			public virtual void changePassword(int accountNumber, string oldPassword, string newPassword)
			{
				Console.WriteLine("the old password OF SBI was " + oldPassword);
				Console.WriteLine("your new password OF SBI is : " + newPassword);
			}
			public virtual void checkBalance(int balance, int amount1)
			{

				if (balance < amount1)
				{
					throw new InsufficientFundsException(amount1 + " not available in your account");
				}
			}
			public static void Main(string[] args)
			{

				sbi SbiAtm = new sbi();
				SbiAtm.changePassword(01, "Larsen", "Toubro");
				SbiAtm.checkBalance(230, 500);
				SbiAtm.withdraw(02, 563.33);

			}

        public void checkBalance()
        {
            throw new NotImplementedException();
        }
    }
		internal class InvalidAmountException : Exception
		{


			public InvalidAmountException() : base()
			{
			}


			public InvalidAmountException(string msg) : base(msg)
			{
			}

		}

		internal class InsufficientFundsException : Exception
		{


			public InsufficientFundsException() : base()
			{
			}

			public InsufficientFundsException(string msg) : base(msg)
			{

			}
		}

	}

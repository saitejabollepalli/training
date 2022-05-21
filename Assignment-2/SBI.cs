using System;
using System.Collections.Generic;
using System.Text;

namespace ATMAssignment
{
	public class sbi : ATM
	{
		public virtual void withdraw(int accountNumber, double amount)
		{
			Console.WriteLine("your account Number of SBI  is : " + accountNumber);
			Console.WriteLine("the amount in your SBI bank is  : " + amount);
		}
		public virtual void changePassword(int accountNumber, string oldPassword, string newPassword)
		{
			Console.WriteLine("the old password OF SBI was " + oldPassword);
			Console.WriteLine("your new password OF SBI is : " + newPassword);
		}

		public virtual void checkBalance(){}
		public static void Main(string[] args)
		{
			sbi SbiAtm = new sbi();
			SbiAtm.changePassword(1732, "PuNeSir", "Hinjewadi");
			SbiAtm.checkBalance();
			SbiAtm.withdraw(1314, 789.65);
		}
	}
}

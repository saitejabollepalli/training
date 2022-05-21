using System;
using System.Collections.Generic;
using System.Text;

namespace ATMAssignment
{
	public class ICICI : ATM
	{

		public virtual void withdraw(int accountNumber, double amount)
		{
			// TODO Auto-generated method stub

			Console.WriteLine("Account Number of ICICI  is : " + accountNumber);
			Console.WriteLine("Amount in your SBI bank is  : " + amount);

		}
		public virtual void changePassword(int accountNumber, string oldPassword, string newPassword)
		{
			// TODO Auto-generated method stub
			Console.WriteLine("Old password OF ICICI was " + oldPassword);
			Console.WriteLine("ew password OF ICICI is : " + newPassword);
		}

		public virtual void checkBalance()
		{
			// TODO Auto-generated method stub

		}
		public static void Main(string[] args)
		{

			ICICI iciciAtm = new ICICI();
			iciciAtm.changePassword(1212121, "ASHISH@20", "20@ASHISH");
			iciciAtm.checkBalance();
			iciciAtm.withdraw(1212121, 0.18277);

		}
	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
	class Program
	{
		static void Main(string[] args)
		{
			PasswordProtector protector = new PasswordProtector();
			ProtectedDoor door = new ProtectedDoor();

			protector.Register(2525, door);

			door.unlock();
			Console.Read();
		}
	}

	abstract class PasswordClient
	{
		protected PasswordProtector myProtector;

		public abstract void alarm();
		public virtual void setMyProtector(PasswordProtector theProtector)
		{
			myProtector = theProtector;
		}
	}

	class PasswordProtector
	{
		private int safeNumber;
		PasswordClient myClient;

		public void Register(int code, PasswordClient client)
		{
			safeNumber = code;
			myClient = client;
			client.setMyProtector(this);
		}

		public void check(int code)
		{
			if (code != safeNumber)
			{
				myClient.alarm();
			}
			else
			{
				Console.WriteLine("Door unlocked!");
			}
		}
	}

	interface Door
	{
		void lockDoor();
		void unlock();
	}

	class ProtectedDoor : PasswordClient, Door
	{
		private bool locked;
		public void lockDoor()
		{
			locked = true;
		}
		public void unlock()
		{
			int number;
			Console.Write("Enter code: ");
			number = Int32.Parse(Console.ReadLine());
			myProtector.check(number);
		}

		public override void alarm()
		{
			Console.WriteLine("ALARM: Someone is trying to enter without code!!");
		}
	}
}

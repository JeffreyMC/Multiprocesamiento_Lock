using System;
using System.Threading;

namespace Lock
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Bathroom banio = new Bathroom();

			Thread persona1 = new Thread(new ThreadStart(banio.usarBanio));
			persona1.Name = "persona_1";
			Thread persona2 = new Thread(new ThreadStart(banio.usarBanio));
			persona2.Name = "persona_2";
			Thread persona3 = new Thread(new ThreadStart(banio.usarBanio));
			persona3.Name = "persona_3";
			Thread persona4 = new Thread(new ThreadStart(banio.usarBanio));
			persona4.Name = "persona_4";

			//se inician los procesos
			persona1.Start();
			persona2.Start();
			persona3.Start();
			persona4.Start();

			Console.ReadKey();
		}
	}
}

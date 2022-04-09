using System;
using System.Threading;

namespace Lock
{
	public class Bathroom
	{
		public void usarBanio()
		{
			Console.WriteLine("La {0} espera afuera del baño", Thread.CurrentThread.Name);
			Thread.Sleep(3000);

			lock (this)
			{
				Console.WriteLine("El baño esta siendo usado por la {0}", Thread.CurrentThread.Name);
				Thread.Sleep(4000);
			}
			//saliendo
			Console.WriteLine("La {0} dejó el baño...", Thread.CurrentThread.Name);

		}
	}
}


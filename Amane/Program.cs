using System;

namespace Amane
{
    class Program
    {
        static void Main(string[] args)
        {
			while(true)
			{
				Console.WriteLine("Select Algorythm:");
				Console.WriteLine("1. Affine");
				Console.WriteLine("2. Vigenere");
				var algo = Console.ReadLine();
				if(algo != "1" && algo != "2")
				{
					Console.WriteLine("Invalid Choice");
					continue;
				}
				Console.WriteLine("Select Mode:");
				Console.WriteLine("1. Encrypt");
				Console.WriteLine("2. Decrypt");
				var mode = Console.ReadLine();
				if (mode != "1" && mode != "2")
				{
					Console.WriteLine("Invalid Choice");
					continue;
				}
				Console.WriteLine("Enter Message:");
				var message = Console.ReadLine();
				if (algo == "1")
				{
					try
					{
						Console.WriteLine("Enter A:");
						var a = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter B:");
						var b = int.Parse(Console.ReadLine());
						if (mode == "1")
						{
							Console.WriteLine("Encrypt:");
							Console.WriteLine(Affine.Encrypt(a, b, message));
							break;
						}else
						{
							Console.WriteLine("Decrypt:");
							Console.WriteLine(Affine.Decrypt(a, b, message));
							break;
						}
					}
					catch
					{
						Console.WriteLine("Invalid Input");
						continue;
					}
				}
				else if (algo == "2")
				{
					Console.WriteLine("Enter Key:");
					var key = Console.ReadLine();
					if(key.Length != message.Length)
					{
						Console.WriteLine("Invalid Key");
						continue;
					}
					if (mode == "1")
					{
						Console.WriteLine("Encrypt:");
						Console.WriteLine(Vigenere.Encrypt(message, key));
						break;
					}
					else
					{
						Console.WriteLine("Decrypt:");
						Console.WriteLine(Vigenere.Decrypt(message, key));
						break;
					}
				}
			}
			Console.WriteLine("Press Enter to exit...");
			Console.ReadLine();
		}
    }
}

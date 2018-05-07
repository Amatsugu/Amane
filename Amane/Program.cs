using System;

namespace Amane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Affine.Decrypt(5, 8, Affine.Encrypt(5, 8, "Hello world")));
			Console.ReadLine();
        }
    }
}

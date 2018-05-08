using System;
using System.Collections.Generic;
using System.Text;

namespace Amane
{

    class Vigenere
    {
		public const int M = char.MaxValue;

		public static string Encrypt(string message, string key)
		{
			if (message.Length != key.Length)
				throw new Exception("Invalid Key");
			var m = message.ToCharArray();
			var k = key.ToCharArray();
			var cypher = new char[m.Length];
			for(int i = 0; i < m.Length; i++)
			{
				cypher[i] = (char)((m[i] + k[i]) % M);
			}
			return new string(cypher);
		}

		public static string Decrypt(string cypherText, string key)
		{
			if (cypherText.Length != key.Length)
				throw new Exception("Invalid Key");
			var c = cypherText.ToCharArray();
			var k = key.ToCharArray();
			var message = new char[c.Length];
			for (int i = 0; i < c.Length; i++)
			{
				message[i] = (char)((c[i] - k[i]) % M);
			}
			return new string(message);
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amane
{

    class Vigenere
    {
		public static readonly List<char> alphabet = new List<char>
		{
			'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',' '
		};
		public static int M => alphabet.Count;

		public static string Encrypt(string message, string key)
		{
			if (message.Length != key.Length)
				throw new Exception("Invalid Key");
			message = message.ToLowerInvariant();
			key = key.ToLowerInvariant();
			var m = message.Select(c => alphabet.IndexOf(c)).ToArray();
			var k = key.Select(c => alphabet.IndexOf(c)).ToArray();
			var cypher = new char[m.Length];
			for(int i = 0; i < m.Length; i++)
			{
				cypher[i] = alphabet[Mod(m[i] + k[i], M)];
			}
			return new string(cypher);
		}

		public static string Decrypt(string cypherText, string key)
		{
			if (cypherText.Length != key.Length)
				throw new Exception("Invalid Key");
			cypherText = cypherText.ToLowerInvariant();
			key = key.ToLowerInvariant();
			var c = cypherText.Select(m => alphabet.IndexOf(m)).ToArray();
			var k = key.Select(m => alphabet.IndexOf(m)).ToArray();
			var message = new char[c.Length];
			for (int i = 0; i < c.Length; i++)
			{
				message[i] = alphabet[Mod(c[i] - k[i], M)];
			}
			return new string(message);
		}

		public static int Mod(int a, int b) => ((a % b) + b) % b;

	}
}

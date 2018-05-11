using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amane
{
    class Affine
    {
		public static readonly List<char> alphabet = new List<char>
		{
			'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',' '
		};
		public static int M => alphabet.Count;

		public static string Encrypt(int a, int b, string message)
		{
			message = message.ToLowerInvariant();
			int[] charArr = message.Select(c => alphabet.IndexOf(c)).ToArray();
			char[] cypher = new char[charArr.Length];
			for(var i = 0; i < charArr.Length; i++)
			{
				cypher[i] = alphabet[(((a * charArr[i]) + b) % M)];
			}
			return new string(cypher);
		}

		public static string Decrypt(int a, int b, string cypherText)
		{
			cypherText = cypherText.ToLowerInvariant();
			int[] charArr = cypherText.Select(c => alphabet.IndexOf(c)).ToArray();
			char[] message = new char[charArr.Length];
			var aa = GetAInv(a);
			for (var i = 0; i < charArr.Length; i++)
			{
				var c = Mod(aa * (charArr[i] - b), M);
				message[i] = alphabet[c];
			}
			return new string(message);
		}

		public static int Mod(int a, int b) => (a % b + b) % b;

		public static int GetAInv(int a)
		{
			for(int i = 0; i <= M-1; i++)
			{
				if ((a * i) % M == 1)
					return i;
			}
			return -1;
		}
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Amane
{
    class Affine
    {
		public const int M = char.MaxValue;

		public static string Encrypt(int a, int b, string message)
		{
			char[] charArr = message.ToCharArray();
			char[] cypher = new char[charArr.Length];
			for(var i = 0; i < charArr.Length; i++)
			{
				cypher[i] = (char)(((a * charArr[i]) + b) % M);
			}
			return new string(cypher);
		}

		public static string Decrypt(int a, int b, string cypherText)
		{
			char[] charArr = cypherText.ToCharArray();
			char[] message = new char[charArr.Length];
			for (var i = 0; i < charArr.Length; i++)
			{
				message[i] = (char)((Math.Pow(a, -1) * (charArr[i] - b)) % M);
			}
			return new string(message);
		}
    }
}

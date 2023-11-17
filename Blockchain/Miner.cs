using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Sistema_contable
{
	public class Miner
	{
		static int dificultad = 4;
		/// Calcula el HASH
		/// <param name="text"></param>
		/// <returns>calculo del HASH</returns>
		public static String CalculateHash(String text)
		{

			String myHashCalculated = String.Empty;
			using (SHA256 mySHA256 = SHA256.Create())
			{
				byte[] encodedText = new UTF8Encoding().GetBytes(text);
				byte[] myHashArray = mySHA256.ComputeHash(encodedText);
				myHashCalculated = BitConverter.ToString(myHashArray).Replace("-", String.Empty);

			}
			return myHashCalculated;
		}
		public static String MineBlock(Seat seat)
		{
			String hash = "";
			int proof = 0;
			String zeros = String.Empty.PadLeft(dificultad, '0');

			do
			{
				String text = String.Format("{0}{1}{2}", seat.Date, seat._HashSeat, proof);
				hash = Miner.CalculateHash(text);
				proof++;
			} while (!hash.StartsWith(zeros));

			return hash;
		}
	}
}
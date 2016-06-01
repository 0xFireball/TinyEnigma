/*
 */
using System;
using System.IO;

namespace TinyEngima.Core
{
	/// <summary>
	/// Common class for TinyEnigma
	/// </summary>
	public static class TinyEngimaCommon
	{
		public static TinyEnigmaCryptor Cryptor = new TinyEnigmaCryptor();
		
		public static void RunCryptoOnFile(string inputFile, string outputFile, string passphrase, bool encrypt)
		{
			byte[] inputBytes = File.ReadAllBytes(inputFile);
			byte[] outputBytes = encrypt ? Cryptor.GetEncryptedBytes(inputBytes, passphrase) : Cryptor.GetDecryptedBytes(inputBytes, passphrase);
			File.WriteAllBytes(outputFile, outputBytes);
		}
	}
}

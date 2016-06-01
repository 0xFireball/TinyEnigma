/*
 */
using System;
using OmniBean.PowerCrypt4;
using OmniBean.PowerCrypt4.Utilities;

namespace TinyEngima.Core
{
	public class TinyEnigmaCryptor
	{
		private readonly AESProvider _aesProvider;
		public TinyEnigmaCryptor()
		{
			_aesProvider = new AESProvider();
		}
		
		public byte[] GetEncryptedBytes(byte[] input, string passphrase)
		{
			return _aesProvider.EncryptString(input.GetString(), passphrase).GetBytes();
		}
		
		public byte[] GetDecryptedBytes(byte[] input, string passphrase)
		{
			return _aesProvider.DecryptString(input.GetString(), passphrase).GetBytes();
		}
	}
}

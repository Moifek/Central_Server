using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YesSIMobileAPI.Services
{
    public class Encryption
    {
        private static string salt = "This is just something to do the dirty work, behh !";

        public static byte[] GetHashKey(string hashKey)
        {
            try
            {
                // Initialize
                UTF8Encoding encoder = new UTF8Encoding();
                // Get the salt
                string theSalt = !string.IsNullOrEmpty(salt) ? salt : "I am a nice little salt";
                byte[] saltBytes = encoder.GetBytes(theSalt);
                // Setup the hasher
                Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(hashKey, saltBytes);
                // Return the key
                return rfc.GetBytes(16);
            }
            catch
            {
                throw new("hash problem");
            }
        }

        public static string Encrypt(byte[] key, string dataToEncrypt)
        {
            try
            {
                // Initialize
                RijndaelManaged encryptor = new RijndaelManaged();
                encryptor.Padding = PaddingMode.PKCS7;
                encryptor.BlockSize = 128;
                // Set the key
                encryptor.Key = key;
                encryptor.IV = key;
                // create a memory stream
                using (MemoryStream encryptionStream = new MemoryStream())
                {
                    // Create the crypto stream
                    using (CryptoStream encrypt = new CryptoStream(encryptionStream, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        // Encrypt
                        byte[] utfD1 = UTF8Encoding.UTF8.GetBytes(dataToEncrypt);
                        encrypt.Write(utfD1, 0, utfD1.Length);
                        encrypt.FlushFinalBlock();
                        encrypt.Close();
                        // Return the encrypted data
                        return Convert.ToBase64String(encryptionStream.ToArray());
                    }
                }
            }
            catch
            {
                throw new("Il y a un problème avec l'identification du logiciel !");
            }
        }
    }
}

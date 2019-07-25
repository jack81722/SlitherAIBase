using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1.Tool
{
    public static class StringEncrypt
    {
        public static string Encrypt(string plainText, string key)
        {
            var sha256 = new SHA256CryptoServiceProvider();
            var hashKey = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
            var bytes = encrypt(plainText, hashKey);
            return Convert.ToBase64String(bytes);
        }

        private static byte[] encrypt(string plainText, byte[] key)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentException("plainText");
            if (key == null || key.Length == 0)
                throw new ArgumentException("key");

            var toEncryptBytes = Encoding.UTF8.GetBytes(plainText);
            using (var provider = new AesCryptoServiceProvider())
            {
                provider.Key = key;
                provider.Mode = CipherMode.CBC;
                provider.Padding = PaddingMode.PKCS7;
                using (var encryptor = provider.CreateEncryptor(provider.Key, provider.IV))
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(provider.IV, 0, 16);
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(toEncryptBytes, 0, toEncryptBytes.Length);
                            cs.FlushFinalBlock();
                        }

                        return ms.ToArray();
                    }
                }
            }
        }

        public static string Decrypt(string encryptText, string key)
        {
            var bytes = Convert.FromBase64String(encryptText);
            var sha256 = new SHA256CryptoServiceProvider();
            var hashKey = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
            return decrypt(bytes, hashKey);
        }

        private static string decrypt(byte[] encryptedBytes, byte[] encryptionKey)
        {
            using (var provider = new AesCryptoServiceProvider())
            {
                provider.Key = encryptionKey;
                provider.Mode = CipherMode.CBC;
                provider.Padding = PaddingMode.PKCS7;
                using (var ms = new MemoryStream(encryptedBytes))
                {
                    byte[] buffer = new byte[16];
                    ms.Read(buffer, 0, 16);
                    provider.IV = buffer;
                    using (var decryptor = provider.CreateDecryptor(provider.Key, provider.IV))
                    {
                        using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            byte[] decrypted = new byte[encryptedBytes.Length];
                            var byteCount = cs.Read(decrypted, 0, encryptedBytes.Length);
                            return Encoding.UTF8.GetString(decrypted, 0, byteCount);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="plainText">加密前字串</param>
        /// <param name="cryptoKey">加密金鑰</param>
        /// <returns>加密後字串</returns>
        public static string Encrypt2(string plainText, string cryptoKey)
        {
            var aes = new AesCryptoServiceProvider();
            var md5 = new MD5CryptoServiceProvider();
            var sha256 = new SHA256CryptoServiceProvider();
            aes.Key = sha256.ComputeHash(Encoding.UTF8.GetBytes(cryptoKey));
            aes.IV = md5.ComputeHash(Encoding.UTF8.GetBytes(cryptoKey));

            string encrypt;
            var dataBytes = Encoding.UTF8.GetBytes(plainText);
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(dataBytes, 0, dataBytes.Length);
                    cs.FlushFinalBlock();
                    encrypt = Convert.ToBase64String(ms.ToArray());
                }
            }

            return encrypt;
        }

        /// <summary>
        /// </summary>
        /// <param name="encryptText"></param>
        /// <param name="cryptoKey">解密金鑰</param>
        /// <returns>解密後字串</returns>
        public static string Decrypt2(string encryptText, string cryptoKey)
        {
            var aes = new AesCryptoServiceProvider();
            var md5 = new MD5CryptoServiceProvider();
            var sha256 = new SHA256CryptoServiceProvider();
            aes.Key = sha256.ComputeHash(Encoding.UTF8.GetBytes(cryptoKey));
            aes.IV = md5.ComputeHash(Encoding.UTF8.GetBytes(cryptoKey));

            string decrypt;
            var dataBytes = Convert.FromBase64String(encryptText);
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(dataBytes, 0, dataBytes.Length);
                    cs.FlushFinalBlock();
                    decrypt = Encoding.UTF8.GetString(ms.ToArray());
                }
            }

            return decrypt;
        }
    }

}


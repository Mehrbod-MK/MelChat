using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MelChatAPI.Common
{
    public static class Helpers
    {
        public static BackgroundWorker CreateWorker(bool supportCancellation, bool supportProgress,
            DoWorkEventHandler doWorkEvent, ProgressChangedEventHandler progressChanged, RunWorkerCompletedEventHandler runWorkerCompletedEventHandler,
            bool autoStart = true)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker()
            {
                WorkerSupportsCancellation = supportCancellation,
                WorkerReportsProgress = supportProgress,
            };
            backgroundWorker.DoWork += doWorkEvent;
            backgroundWorker.ProgressChanged += progressChanged;
            backgroundWorker.RunWorkerCompleted += runWorkerCompletedEventHandler;
            if (autoStart)
                backgroundWorker.RunWorkerAsync(backgroundWorker);
            return backgroundWorker;
        }

        public static string HashPasswordPBKDF2(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16); // 128-bit salt
            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(32); // 256-bit hash
            return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        public static bool VerifyPasswordPBKDF2(string password, string storedHash)
        {
            var parts = storedHash.Split(':');
            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] storedPasswordHash = Convert.FromBase64String(parts[1]);
            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256);
            byte[] computedHash = pbkdf2.GetBytes(32);
            return CryptographicOperations.FixedTimeEquals(computedHash, storedPasswordHash);
        }

        public static bool ExtractAddressAndPortFromString(string input, out string address, out int port)
        {
            var splitInput = input.Split([':'], StringSplitOptions.RemoveEmptyEntries);
            if(splitInput.Length < 1)
            {
                address = string.Empty;
                port = -1;
                return false;
            }
            else if(splitInput.Length < 2)
            {
                address = splitInput[0];
                port = -1;
                return false;
            }
            else if (int.TryParse(splitInput[1], out int portNumber))
            {
                address = splitInput[0];
                port = portNumber;
                return true;
            }
            else
            {
                address = splitInput[0];
                port = -1;
                return false;
            }
        }
    }
}

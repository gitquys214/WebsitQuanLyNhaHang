using System;
using System.Security.Cryptography;
using System.Text;

namespace ASMC5.Services
{
    public interface IMahoaHelper
    {
        string Mahoa(string source);
    }

    public class MaHoaSvc:IMahoaHelper
    {
        public string Mahoa(string source)
        {
            string hash = "";
            using (var md5Hash = MD5.Create())
            {
                var sourceBytes = Encoding.UTF8.GetBytes(source);
                var hashBytes = md5Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }
            return hash;
        }

    }
}

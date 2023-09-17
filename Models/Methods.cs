using System.Text;

namespace BettingApp.Models
{
    public class Methods
    {
        public static string RandomString(int length)
        {
            Random random = new Random();
            string chars = "abcdefghijklmnopqrstuvwxyz0123456789";

            StringBuilder sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }
            
            return sb.ToString();
        }
    }
}
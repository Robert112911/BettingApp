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

        public static string TranslateDayOfWeek(DayOfWeek day)
        {
            switch(day)
            {
                case DayOfWeek.Monday:
                    return "LUNI";
                    break;

                case DayOfWeek.Tuesday:
                    return "MAR.";
                    break;

                case DayOfWeek.Wednesday:
                    return "MIE.";
                    break;

                case DayOfWeek.Thursday:
                    return "JOI";
                    break;

                case DayOfWeek.Friday:
                    return "VIN.";
                    break;

                case DayOfWeek.Saturday:
                    return "SÂM.";
                    break;

                default:
                    return "DUM.";
                    break;
            }
        }
    }
}
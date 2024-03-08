using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03._Telephony.Interfaces;

namespace _03._Telephony
{
    public class Smartphone : IBrowser, ICaller
    {
        public string Browse(string url)
        {
            if (ValidateURL(url))
            {
                return $"Browsing: {url}!";
            }

            return "Invalid URL!";
        }

        public string Call(string phoneNumber)
        {
            if (ValidatePhoneNUmber(phoneNumber))
            {
                return $"Calling... {phoneNumber}";
            }

            return "Invalid number!";
        }


        private bool ValidateURL(string url)
        {
            bool valid = true;

            foreach (char character in url)
            {
                if (char.IsDigit(character))
                {
                    valid = false;
                    break;
                }
            }

            return valid;
        }

        private bool ValidatePhoneNUmber(string phoneNumber)
        {
            bool valid = true;

            foreach (char character in phoneNumber)
            {
                if (!char.IsDigit(character))
                {
                    valid = false;
                    break;
                }
            }

            if (phoneNumber.Length != 10)
            {
                valid = false;
            }

            return valid;
        }
    }
}

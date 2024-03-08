using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03._Telephony.Interfaces;

namespace _03._Telephony
{
    public class StationaryPhone : ICaller
    {
        public string Call(string phoneNumber)
        {
            if (ValidatePhoneNUmber(phoneNumber))
            {
                return $"Dialing... {phoneNumber}";
            }

            return "Invalid number!";
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

            if (phoneNumber.Length != 7)
            {
                valid = false;
            }

            return valid;
        }
    }
}

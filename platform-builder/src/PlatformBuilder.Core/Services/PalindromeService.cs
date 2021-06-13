using PlatformBuilder.Abstractions.Services;
using System;
using System.Linq;

namespace PlatformBuilder.Core.Services
{
    public class PalindromeService : IPalindromeService
    {
        public bool IsPalindrome(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return true;

            for (int i = 0; i < value.Length; i++)
            {
                int reverseIndex = value.Length - (i + 1);

                if (value[i].ToString().ToLower() != value[reverseIndex].ToString().ToLower())
                {
                    return false;
                }
            }
                        
            return true;
        }
    }
}

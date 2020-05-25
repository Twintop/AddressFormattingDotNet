using System;
using AddressFormattingDotNet;

namespace AddressFormattingDotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var addressFormatting = new AddressFormatting();
            addressFormatting.LoadComponentAliases();

            foreach (var x in addressFormatting._componentMapping)
            {
                Console.WriteLine(x.Key, x.Value);
            }
        }
    }
}

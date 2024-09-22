using System;
namespace TestApp.Models
{
	public class User
	{
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }

        
    }

    public class Country
    {
        public string Name { get; set; }
        public string Alpha2 { get; set; }
        public string PhoneCountryCode { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencySign { get; set; }
    }
}


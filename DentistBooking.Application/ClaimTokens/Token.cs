using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.Application.NewFolder
{
    public class Token
    {
        public string Tokens { get; set; }
        public string AccessTokens { get; set; }
        public Token(string tokens,string accessTokens)
        {
            Tokens = tokens;
            AccessTokens = accessTokens;
        }
    }
}

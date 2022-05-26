using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBooking.Application.ClaimTokens
{
    public class RefreshTokenResponse
    {
        public string Token { get; set; }

        public string Message { get; set; }

        public string Code { get; set; }
    }
}

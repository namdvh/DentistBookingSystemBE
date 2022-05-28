using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokkingDentist.Constant
{
    public class JwtException:Exception
    {
        public string code { get; }

        public JwtException() { }

        public JwtException(string msg)
            : base(msg) { }

        public JwtException(string msg, Exception inner)
            : base(msg, inner) { }

        public JwtException(string msg, string code)
            : this(msg)
        {
            this.code = code;
        }
    }
}

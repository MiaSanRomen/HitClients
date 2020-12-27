using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitClients.Api.Types.Requests
{
    public class CandleRequest
    {
        public string Symbol;
        public string Period;
        public string Sort;
        public DateTime From;
        public DateTime Till;
        public int Limit;
        public int Offset;
    }
}

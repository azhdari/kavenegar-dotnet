using Kavenegar.Models;
using System.Collections.Generic;

namespace Kavenegar.Internal
{
    internal class ReturnReceive
    {
        public Result result { get; set; }
        public List<ReceiveResult> entries { get; set; }
    }
}

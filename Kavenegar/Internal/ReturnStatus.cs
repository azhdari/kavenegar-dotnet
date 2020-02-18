using Kavenegar.Models;
using System.Collections.Generic;

namespace Kavenegar.Internal
{
    internal class ReturnStatus
    {
        public Result result { get; set; }
        public List<StatusResult> entries { get; set; }
    }
}

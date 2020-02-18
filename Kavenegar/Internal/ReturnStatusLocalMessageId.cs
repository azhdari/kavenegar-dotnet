using Kavenegar.Models;
using System.Collections.Generic;

namespace Kavenegar.Internal
{
    internal class ReturnStatusLocalMessageId
    {
        public Result result { get; set; }
        public List<StatusLocalMessageIdResult> entries { get; set; }
    }
}

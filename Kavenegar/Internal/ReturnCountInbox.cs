using Kavenegar.Models;
using System.Collections.Generic;

namespace Kavenegar.Internal
{
    internal class ReturnCountInbox
    {
        public Result result { get; set; }
        public List<CountInboxResult> entries { get; set; }

    }
}

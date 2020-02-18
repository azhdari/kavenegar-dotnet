using Kavenegar.Models;
using System.Collections.Generic;

namespace Kavenegar.Internal
{
    internal class ReturnCountOutbox
    {
        public Result result { get; set; }
        public List<CountOutboxResult> entries { get; set; }
    }
}

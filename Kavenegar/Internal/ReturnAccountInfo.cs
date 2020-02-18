using Kavenegar.Models;

namespace Kavenegar.Internal
{
    internal class ReturnAccountInfo
    {
        public Result result { get; set; }
        public AccountInfoResult entries { get; set; }
    }
}

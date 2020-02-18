using Kavenegar.Models.Enums;

namespace Kavenegar.Exceptions
{
    public class ApiException : KavenegarException
    {
        public ApiException(string message, MetaCode code)
            : base(message)
        {
            Code = code;
        }

        public MetaCode Code { get; }
    }
}

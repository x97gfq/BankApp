using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class CustomStrings
    {
        public const string CANNOT_PAY_INTEREST_ON_ZERO = "Cannot pay interest on a negative or zero amount";
        public const string CANNOT_DEPOSIT_NEGATIVE = "Cannot deposit a negative or zero amount";
        public const string CANNOT_DEPOSIT_MORE_THAN_MAX = "Cannot deposit more than maximum amount per transaction";
        public const string CANNOT_WITHDRAW_NEGATIVE = "Cannot withdraw a negative or zero amount";
        public const string CANNOT_WITHDRAW_MORE_THAN_MAX = "Cannot withdraw more than maximum amount per transaction";
        public const string CANNOT_WITHDRAW_MORE_THAN_AVALIABLE = "Cannot withdraw more money than is available";

    }
}

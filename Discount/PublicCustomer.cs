using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    public class PublicCustomer : Customer
    {
        public override void CalculateDiscount()
        {
            _discountPercentage = 5;
        }
    }
}

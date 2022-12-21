using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    public class Customer
    {
        protected decimal _discountPercentage;

        public decimal DiscountPercentage
        {
            get
            {
                CalculateDiscount();
                return _discountPercentage;
            }
            set { _discountPercentage = value; }
        }

        public virtual void CalculateDiscount()
        {
            _discountPercentage = 0;
        }
    }
}

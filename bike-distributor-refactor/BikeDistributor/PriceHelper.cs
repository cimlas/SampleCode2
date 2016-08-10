using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor
{
    public static class PriceHelper
    {
        public const double TaxRate = .0725d;
        public const int OneThousand = 1000;
        public const int TwoThousand = 2000;
        public const int FiveThousand = 5000;

        public static double GetDiscountPrice(Line pLine)
        {
            var price = 0d;

            switch (pLine.Bike.Price)
            {
                case OneThousand:
                    if (pLine.Quantity >= 20)
                        price += pLine.Quantity * pLine.Bike.Price * .9d;
                    else
                        price += pLine.Quantity * pLine.Bike.Price;
                    break;
                case TwoThousand:
                    if (pLine.Quantity >= 10)
                        price += pLine.Quantity * pLine.Bike.Price * .8d;
                    else
                        price += pLine.Quantity * pLine.Bike.Price;
                    break;
                case FiveThousand:
                    if (pLine.Quantity >= 5)
                        price += pLine.Quantity * pLine.Bike.Price * .8d;
                    else
                        price += pLine.Quantity * pLine.Bike.Price;
                    break;
            }

            return price;
        }
    }
}

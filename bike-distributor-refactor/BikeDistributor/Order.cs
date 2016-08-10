using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BikeDistributor.Exporters;

namespace BikeDistributor
{
    public class Order
    {
        private readonly IList<Line> _lines = new List<Line>();

        public Order(string pCompany)
        {
            Company = pCompany;
        }

        public string Company { get; private set; }

        public void AddLine(Line pLine)
        {
            _lines.Add(pLine);
        }

        public string RenderReceipt(IExporter pExporter, double pTaxRate = PriceHelper.TaxRate)
        {
            var totalAmount = 0d;

            var result = new StringBuilder();
            pExporter.RenderTitle(result, Company);

            if (_lines.Any())
            {
                pExporter.RenderListHeader(result);

                foreach (var l in _lines)
                {
                    var discountedPrice = PriceHelper.GetDiscountPrice(l);
                    pExporter.RenderLine(result, l, discountedPrice);
                    totalAmount += discountedPrice;
                }
                pExporter.RenderListFooter(result);
            }
            pExporter.RenderSubTotal(result, totalAmount);
            var tax = totalAmount * pTaxRate;
            pExporter.RenderTax(result, tax);
            pExporter.RenderTotal(result, totalAmount, tax);
            pExporter.RenderFooter(result);
            return result.ToString();
        }
    }
}

using System;
using System.Text;

namespace BikeDistributor.Exporters
{
    public class TextExporter : IExporter
    {

        public void RenderTitle(StringBuilder pBuilder, string pCompany)
        {
            pBuilder.Append($"Order Receipt for {pCompany}{Environment.NewLine}");
        }

        public void RenderListHeader(StringBuilder pBuilder)
        {
            
        }

        public void RenderListFooter(StringBuilder pBuilder)
        {
            
        }

        public void RenderLine(StringBuilder pBuilder, Line pLine, double pDiscountedPrice)
        {
            pBuilder.AppendLine($"\t{pLine.Quantity} x {pLine.Bike.Brand} {pLine.Bike.Model} = {pDiscountedPrice.ToString("C")}");
        }

        public void RenderSubTotal(StringBuilder pBuilder, double pTotalAmount)
        {
            pBuilder.AppendLine($"Sub-Total: {pTotalAmount.ToString("C")}");
        }

        public void RenderTax(StringBuilder pBuilder, double pTax)
        {
            pBuilder.AppendLine($"Tax: {pTax.ToString("C")}");
        }

        public void RenderTotal(StringBuilder pBuilder, double pTotalAmount, double pTax)
        {
            pBuilder.Append($"Total: {(pTotalAmount + pTax).ToString("C")}");
        }

        public void RenderFooter(StringBuilder pBuilder)
        {
            
        }
    }
}

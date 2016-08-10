using System.Text;

namespace BikeDistributor.Exporters
{
    public class HtmlExporter : IExporter
    {

        public void RenderTitle(StringBuilder pBuilder, string pCompany)
        {
            pBuilder.Append($"<html><body><h1>Order Receipt for {pCompany}</h1>");
        }

        public void RenderListHeader(StringBuilder pBuilder)
        {
            pBuilder.Append("<ul>");
        }

        public void RenderListFooter(StringBuilder pBuilder)
        {
            pBuilder.Append("</ul>");
        }

        public void RenderLine(StringBuilder pBuilder, Line pLine, double pDiscountedPrice)
        {
            pBuilder.Append($"<li>{pLine.Quantity} x {pLine.Bike.Brand} {pLine.Bike.Model} = {pDiscountedPrice.ToString("C")}</li>");
        }

        public void RenderSubTotal(StringBuilder pBuilder, double pTotalAmount)
        {
            pBuilder.Append($"<h3>Sub-Total: {pTotalAmount.ToString("C")}</h3>");
        }

        public void RenderTax(StringBuilder pBuilder, double pTax)
        {
            pBuilder.Append($"<h3>Tax: {pTax.ToString("C")}</h3>");
        }

        public void RenderTotal(StringBuilder pBuilder, double pTotalAmount, double pTax)
        {
            pBuilder.Append($"<h2>Total: {(pTotalAmount + pTax).ToString("C")}</h2>");
        }

        public void RenderFooter(StringBuilder pBuilder)
        {
            pBuilder.Append("</body></html>");
        }
    }
}

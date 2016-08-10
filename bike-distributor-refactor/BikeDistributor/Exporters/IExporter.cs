using System.Text;

namespace BikeDistributor.Exporters
{
    public interface IExporter
    {
        void RenderTitle(StringBuilder pBuilder, string pCompany);

        void RenderListHeader(StringBuilder pBuilder);

        void RenderListFooter(StringBuilder pBuilder);

        void RenderLine(StringBuilder pBuilder, Line pLine, double pDiscountedPrice);

        void RenderSubTotal(StringBuilder pBuilder, double pTotalAmount);

        void RenderTax(StringBuilder pBuilder, double pTax);

        void RenderTotal(StringBuilder pBuilder, double pTotalAmount, double pTax);

        void RenderFooter(StringBuilder pBuilder);

    }
}

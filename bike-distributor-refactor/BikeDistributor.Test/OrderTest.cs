using System;
using BikeDistributor.Enums;
using BikeDistributor.Exporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeDistributor.Test
{
    [TestClass]
    public class OrderTest
    {
        private string _textReceiptFormat = "Order Receipt for {0}" + Environment.NewLine +
                                            "\t{1} x {2} {3} = {4}" + Environment.NewLine +
                                            "Sub-Total: {5}" + Environment.NewLine +
                                            "Tax: {6}" + Environment.NewLine +
                                            "Total: {7}";


        private string _htmlReceiptFormat = @"<html><body><h1>Order Receipt for {0}</h1><ul><li>{1} x {2} {3} = {4}</li></ul><h3>Sub-Total: {5}</h3><h3>Tax: {6}</h3><h2>Total: {7}</h2></body></html>";

        [TestMethod]
        public void ReceiptOneDefy()
        {
            ReceiptBike(BikeDictionary.BikeDefinitions[BikeIdentifierEnum.Defy], new TextExporter(), _textReceiptFormat);
        }

        [TestMethod]
        public void ReceiptOneElite()
        {
            ReceiptBike(BikeDictionary.BikeDefinitions[BikeIdentifierEnum.Elite], new TextExporter(), _textReceiptFormat);
        }

        [TestMethod]
        public void ReceiptOneDuraAce()
        {
            ReceiptBike(BikeDictionary.BikeDefinitions[BikeIdentifierEnum.DuraAce], new TextExporter(), _textReceiptFormat);
        }

        [TestMethod]
        public void HtmlReceiptOneDefy()
        {
            ReceiptBike(BikeDictionary.BikeDefinitions[BikeIdentifierEnum.Defy], new HtmlExporter(), _htmlReceiptFormat);
        }

        [TestMethod]
        public void HtmlReceiptOneElite()
        {
            ReceiptBike(BikeDictionary.BikeDefinitions[BikeIdentifierEnum.Elite], new HtmlExporter(), _htmlReceiptFormat);
        }

        [TestMethod]
        public void HtmlReceiptOneDuraAce()
        {
            ReceiptBike(BikeDictionary.BikeDefinitions[BikeIdentifierEnum.DuraAce], new HtmlExporter(), _htmlReceiptFormat);
        }

        public void ReceiptBike(Bike pBike, IExporter pExporter, string pFormat)
        {
            var order = new Order("Anywhere Bike Shop");
            var line = new Line(pBike, 1);
            order.AddLine(line);
            var subTotal = pBike.Price * line.Quantity;
            var taxes = subTotal * PriceHelper.TaxRate;
            var total = subTotal + taxes;
            Assert.AreEqual(string.Format(_textReceiptFormat, order.Company, line.Quantity, pBike.Brand, pBike.Model, pBike.Price.ToString("C"), subTotal.ToString("C"), taxes.ToString("C"), total.ToString("C")), order.RenderReceipt(new TextExporter()));
        }
    }
}
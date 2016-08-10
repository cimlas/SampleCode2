namespace BikeDistributor
{
    public class Bike
    {
        public Bike(string pBrand, string pModel, int pPrice)
        {
            Brand = pBrand;
            Model = pModel;
            Price = pPrice;
        }

        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Price { get; set; }
    }
}

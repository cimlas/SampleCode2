using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeDistributor.Enums;

namespace BikeDistributor
{
    public static class BikeDictionary
    {
        private static Dictionary<BikeIdentifierEnum, Bike> _bikeDefinitions;

        public static Dictionary<BikeIdentifierEnum, Bike> BikeDefinitions => _bikeDefinitions ?? (_bikeDefinitions = new Dictionary<BikeIdentifierEnum, Bike>
        {
            {
                BikeIdentifierEnum.Defy,
                new Bike(BikeBrandEnum.Giant.GetDescription(), BikeModelEnum.Defy1.GetDescription(), PriceHelper.OneThousand)
            },
            {
                BikeIdentifierEnum.Elite,
                new Bike(BikeBrandEnum.Specialized.GetDescription(), BikeModelEnum.VengeElite.GetDescription(), PriceHelper.TwoThousand)
            },
            {
                BikeIdentifierEnum.DuraAce,
                new Bike(BikeBrandEnum.Specialized.GetDescription(), BikeModelEnum.SWorksVengeDuraAce.GetDescription(), PriceHelper.FiveThousand)
            },
        });
    }
}
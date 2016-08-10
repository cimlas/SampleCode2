using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeDistributor.Enums;

namespace BikeDistributor
{
    public class BikeIdentifier
    {
        private readonly BikeBrandEnum _brand;
        private readonly BikeModelEnum _model;

        public BikeIdentifier(BikeBrandEnum pBrand, BikeModelEnum pModel)
        {
            _brand = pBrand;
            _model = pModel;
        }

        public string Identity()
        {
            return Enum.GetName(typeof(BikeBrandEnum), _brand) + " " + Enum.GetName(typeof(BikeModelEnum), _model);
        }
    }
}

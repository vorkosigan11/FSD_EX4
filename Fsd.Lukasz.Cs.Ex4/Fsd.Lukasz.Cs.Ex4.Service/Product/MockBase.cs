using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Lukasz.Cs.Ex4.Data.Entities;

namespace Fsd.Lukasz.Cs.Ex4.Services.Product
{
    public class MockBase : IProductServive
    {
        private IEnumerable<ProductBase> SampleData()
        {
            IList<ProductBase> results = new List<ProductBase>();

            results.Add(new Bike("Kelly's", "Quartz", 1456, new DateTime(2016,1,1), ProductType.Bike, 27, "Suntour"));
            results.Add(new Bike("Cube", "AIM Race", 2456, new DateTime(2016, 1, 1), ProductType.Bike, 27, "Suntour"));
            results.Add(new Bike("Ghost", "Lanao 1", 2356, new DateTime(2016, 1, 1), ProductType.Bike, 27, "RST"));
            results.Add(new Bike("Orbea", "MX 50", 2229, new DateTime(2016, 1, 1), ProductType.Bike, 27, "Suntour"));
            results.Add(new Bike("Liv", "Bliss", 2139, new DateTime(2016, 1, 1), ProductType.Bike, 27, "Suntour"));
            results.Add(new Bike("Focus", "Whistler", 2149, new DateTime(2016, 1, 1), ProductType.Bike, 27, "Suntour"));
            results.Add(new Bike("Cube", "Access", 1969, new DateTime(2016, 1, 1), ProductType.Bike, 27, "XCT"));
            results.Add(new Chain("Sram", "PC-1", 38, new DateTime(2016,1,1), ProductType.Chain, 114));
            results.Add(new Chain("Sram", "PC-830", 35, new DateTime(2016, 1, 1), ProductType.Chain, 114));
            results.Add(new Chain("Shimano", "Nexus CN-NX1", 31, new DateTime(2016, 1, 1), ProductType.Chain, 114));
            results.Add(new Chain("BBB", "BCH-010", 36, new DateTime(2016, 1, 1), ProductType.Chain, 114));
            results.Add(new Chain("RFR", "Z1", 34, new DateTime(2016, 1, 1), ProductType.Chain, 114));
            results.Add(new Brake("Shimano", "Dura Ace BR-R9100", 785, new DateTime(2016,1,1), ProductType.Brake, BrakeType.DualPivot));
            results.Add(new Brake("Shimano", "Dura-Ace BR-9010", 760, new DateTime(2016, 1, 1), ProductType.Brake, BrakeType.Cantilever));
            results.Add(new Brake("Magura", "HS11", 265, new DateTime(2016, 1, 1), ProductType.Brake, BrakeType.DiskHydraulical));
            results.Add(new Brake("Avid", "Singlee Digit 5", 85, new DateTime(2016, 1, 1), ProductType.Brake, BrakeType.VBrake));

            return results;
        }

        public IEnumerable<ProductBase> GetAllProducts()
        {
            return SampleData();
        }

        public ProductBase GetProduct(int index)
        {
            throw new NotImplementedException();
        }
    }
}

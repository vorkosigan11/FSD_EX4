
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs.Ex4.Data.Entities
{
public     class Chain : ProductBase, IChain
    {
        #region Constructors

        public Chain(string producer, string model, decimal price, DateTime productoinDate, ProductType type, int numberOfLinks) : base(producer, model, price, productoinDate, type)
        {
            type = ProductType.Chain;
            NumberOfLinks = numberOfLinks;
        }

        #endregion Constructors

        #region Properties

        public int NumberOfLinks { get; set; }

        #endregion Properties
    }
}

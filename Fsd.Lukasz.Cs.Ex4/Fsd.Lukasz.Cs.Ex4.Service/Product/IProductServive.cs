using Fsd.Lukasz.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs.Ex4.Services.Product
{
    public interface IProductServive
    {
        IEnumerable<ProductBase> GetAllProducts();

        ProductBase GetProduct(int index);
    }
}

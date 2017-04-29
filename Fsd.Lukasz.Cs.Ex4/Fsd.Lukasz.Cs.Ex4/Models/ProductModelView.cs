using Fsd.Lukasz.Cs.Ex4.Data.Entities;
using PagedList;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Lukasz.Cs.Ex4.Models
{
    public class ProductModelView
    {
        public IPagedList<ProductModel> ProductList { get; set; }
    }
}
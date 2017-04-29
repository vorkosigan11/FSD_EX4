using Fsd.Lukasz.Cs.Ex4.Data.Entities;
using Fsd.Lukasz.Cs.Ex4.Models;
using Fsd.Lukasz.Cs.Ex4.Services.Product;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Lukasz.Cs.Ex4.Controllers
{
    public class ProductController : Controller
    {
        private IProductServive _productService;

        public ProductController()
        {
            _productService = new MockBase();
        }

        public ActionResult List(int? page, int itemsPerPage = 4)
        {

            //pobrac dane i zamienic na modelview class
            IEnumerable<ProductBase> productList = _productService.GetAllProducts();

            var model = new ProductModelView
            {
                ProductList = new PagedList<ProductModel>(productList.Select(x =>
                                                            new ProductModel
                                                            {
                                                                Producer = x.Producer,
                                                                Model = x.Model,
                                                                Price = x.Price,
                                                                ProductionDate = x.ProductionDate,
                                                                Type = x.Type
                                                            }),
                                page ?? 1,
                                (itemsPerPage < 4) ? 4 : itemsPerPage)
            };
                     
             return View(model);
        }
    }
}
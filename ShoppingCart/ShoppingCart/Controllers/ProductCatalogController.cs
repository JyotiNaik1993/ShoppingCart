using DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCatalogController : ControllerBase
    {
        private readonly IProductCatalogRepository _productCatalogRepository;

        public ProductCatalogController(IProductCatalogRepository productCatalogRepository)
        {
            _productCatalogRepository = productCatalogRepository;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult Get()
        {
            try
            {
                var products = _productCatalogRepository.GetProduct();
                if (products == null)
                {
                    return NotFound();
                }

                return Ok(products);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("GetProductsByLowtoHighPriceRange/{catalogType}")]
        public IActionResult GetProductsByLowtoHighPriceRange(string catalogType)
        {
            try
            {
                var products = _productCatalogRepository.GetProduct();
                if (catalogType.ToLower() == "mensfashion")
                {
                    return Ok(products.MensFashion.OrderByDescending(x => x.ItemPrice).ToList());
                }
                if (catalogType.ToLower() == "mobiles")
                {
                    return Ok(products.Mobiles.OrderByDescending(x => x.ItemPrice).ToList());
                }
                return NotFound();

            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("GetProductsByHightoLowPriceRange/{catalogType}")]
        public IActionResult GetProductsByHightoLowPriceRange(string catalogType)
        {
            try
            {
                var products = _productCatalogRepository.GetProduct();
                if (catalogType.ToLower() == "mensfashion")
                {
                    return Ok(products.MensFashion.OrderBy(x => x.ItemPrice).ToList());
                }
                if (catalogType.ToLower() == "mobiles")
                {
                    return Ok(products.Mobiles.OrderBy(x => x.ItemPrice).ToList());
                }
                return NotFound();

            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("GetProductsByPriceRange/{catalogType}/{startPrice}/{endPrice}")]
        public IActionResult GetProductsByPriceRange(string catalogType, int startPrice, int endPrice)
        {
            try
            {
                var products = _productCatalogRepository.GetProduct();
                if (catalogType.ToLower() == "mensfashion")
                {
                    return Ok(products.MensFashion.Where(x => x.ItemPrice >= startPrice && x.ItemPrice <= endPrice).ToList());
                }
                if (catalogType.ToLower() == "mobiles")
                {
                    return Ok(products.Mobiles.Where(x => x.ItemPrice >= startPrice && x.ItemPrice <= endPrice).ToList());
                }
                return NotFound();

            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("GetProductsByViews/{catalogType}")]
        public IActionResult GetProductsByViews(string catalogType)
        {
            try
            {
                var products = _productCatalogRepository.GetProduct();
                if (catalogType.ToLower() == "mensfashion")
                {
                    return Ok(products.MensFashion.OrderByDescending(x => x.ViewCount).ToList());
                }
                if (catalogType.ToLower() == "mobiles")
                {
                    return Ok(products.Mobiles.OrderByDescending(x => x.ViewCount).ToList());
                }
                return NotFound();

            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
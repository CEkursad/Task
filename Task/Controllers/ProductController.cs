using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Model;
using Task.Model.DTOs;
using Task.Model.ORM;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private readonly TaskDBContext dBContext;

        public ProductController()
            {
                dBContext = new TaskDBContext();
            }

        [HttpGet]
        public IActionResult Get()
        {
            var products = dBContext.Products.ToList();
            List<ProductGetResponse> productsResponse = new List<ProductGetResponse>();
            foreach (var product in products)
            {
                productsResponse.Add(new ProductGetResponse()
                {
                    Price = product.Price,
                    Title = product.Title,
                    Sku = product.Sku,
                    Stock = product.Stock,
                    TitleDomestic = product.TitleDomestic,
                    Barcode = product.Barcode,
                    CurrencyName = product.CurrencyName,
                    HasVideo = product.HasVideo,
                });
            }
            return Ok(productsResponse);
        }
        [HttpPost]
        public IActionResult Post(Product product)
        {
            dBContext.Products.Add(product);
            dBContext.SaveChanges();

            ProductGetResponse productsResponse = new ProductGetResponse()
            {
                Price = product.Price,
                Title = product.Title,
                Sku = product.Sku,
                Stock = product.Stock,
                TitleDomestic = product.TitleDomestic,
                Barcode = product.Barcode,
                CurrencyName = product.CurrencyName,
                HasVideo = product.HasVideo,
            };

            return Ok(productsResponse);
        }
        [HttpPut("{id}")]
        public IActionResult Put(long id,Product product) 
        {
            var updateProduct = dBContext.Products.FirstOrDefault(x => x.ProductStatusId == id);
            if (updateProduct == null)
            {
                return NotFound("Urun bulunamadi.");
            }

            updateProduct.ProductStatusId = product.ProductStatusId;
            updateProduct.Sku = product.Sku;
            updateProduct.ProductStatusName = product.ProductStatusName;
            updateProduct.ProductUrl = product.ProductUrl;
            updateProduct.Title = product.Title;
            updateProduct.Barcode = product.Barcode;
            updateProduct.DescriptionDomestic= product.DescriptionDomestic;
            updateProduct.CurrencyName = product.CurrencyName;
            updateProduct.HasVideo = product.HasVideo;
            updateProduct.Stock = product.Stock;
            updateProduct.WhoMade = product.WhoMade;
            updateProduct.PersonalizationDescription = product.PersonalizationDescription;
            updateProduct.Price = product.Price;
            dBContext.SaveChanges();
            return Ok(updateProduct);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleteProduct = dBContext.Products.FirstOrDefault(x => x.ProductStatusId == id);
            if (deleteProduct == null)
            {
                return NotFound("Urun bulunamadi.");
            }
            dBContext.Products.Remove(deleteProduct);
            dBContext.SaveChanges();
            return Ok(deleteProduct);
        }
    }
}

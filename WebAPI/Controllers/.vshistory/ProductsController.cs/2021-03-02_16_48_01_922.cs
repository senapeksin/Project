﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        /*Dependency chain --bağımlılık zinciri
           Bağımlılığı çözmek için constructor injektion yapalım.Normalde bu sekildeydi;
           IProductService productService = new ProductManager(new EfProductDal());*/

        IProductService _productService;
        public ProductsController(IProductService productService) //loosely coupled:Soyuta bağımlılık var
        {
            _productService = productService;
        }
        [HttpGet]
        public List<Product> Get()
        {
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}

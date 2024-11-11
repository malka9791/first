using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2;
using Yad2.Controllers;

namespace UnitTest
{
    public class TestControllerPro
    {
        [Fact]
        public void GetAll_ReturnsOk()
        {
            //act
            var controller = new ProductsController();
            var result = controller.Get();
            //assert
            Assert.IsType<List<Product>>(result);
        }
        [Fact]
        public void GetById_ReturnsObjectOk()
        {
            //arrange
            var id = 1;
            //act
            var controller = new ProductsController();
            var result = controller.Get(id);
            //assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetAll_NotEmpty()
        {
            var controller = new ProductsController();
            var result = controller.Get();
            Assert.NotEqual(0,result.Count());
        }
        [Fact]
        public void GetAll_IsEmpty()
        {
            var controller = new ProductsController();
            var result = controller.Get();
            Assert.Equal(0, result.Count());
        }
    }
}

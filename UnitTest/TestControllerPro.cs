using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2;
using Yad2.Controllers;
using Yad2.data;
using Yad2.Interface;

namespace UnitTest
{
    public class TestControllerPro
    {
        private readonly ProductsController _context;
        public TestControllerPro()
        {
            FakeContexet context= new FakeContexet();
            _context = new ProductsController(context);
        }
        [Fact]
        public void GetAll_ReturnsOk()
        {
            //act
            var controller = _context;
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
            var controller =_context;
            var result = controller.Get(id);
            //assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetAll_NotEmpty()
        {
            var result = _context.Get();
            Assert.NotEqual(0,result.Count());
        }
        [Fact]
        public void GetAll_IsEmpty()
        {
            var result = _context.Get();
            Assert.Equal(0, result.Count());
        }
    }
}

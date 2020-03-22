using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController valController = new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = valController.Get(1);
            Assert.Equal("Les Jackson", returnValue.Value);


        }

        [Fact]
        public void Test1()
        {

        }
    }
}

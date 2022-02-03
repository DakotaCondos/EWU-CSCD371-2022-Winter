﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JokeServicesTests
    {
        [TestMethod]
        public void JokeServices_ReturnValidString_Success()
        {
            JokeService jokeService = new JokeService();
            Assert.IsNotNull(jokeService.GetJoke());
            Assert.IsInstanceOfType(jokeService.GetJoke(), typeof(string));
        }
    }
}

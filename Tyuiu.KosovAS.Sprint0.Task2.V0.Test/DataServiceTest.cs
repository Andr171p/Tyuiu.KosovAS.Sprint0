﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KosovAS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Андрей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Андрей", res);
        }
    }
}

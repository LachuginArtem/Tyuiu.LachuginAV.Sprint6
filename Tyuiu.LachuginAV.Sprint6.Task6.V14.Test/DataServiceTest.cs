﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.LachuginAV.Sprint6.Task6.V14.Lib;

namespace Tyuiu.LachuginAV.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Admin\source\repos\Tyuiu.LachuginAV.Sprint6\Tyuiu.LachuginAV.Sprint6.Task6.V14\bin\Debug\InPutFileTask6V14.txt";
            string wait = " GzTsc AucHJjziZ jiUFMDjMsEervIz ziwVyU";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.LachuginAV.Sprint6\Tyuiu.LachuginAV.Sprint6.Task6.V14\bin\Debug\InPutFileTask6V14.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
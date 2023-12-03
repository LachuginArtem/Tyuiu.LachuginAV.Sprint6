using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint6.Task1.V9.Lib;

namespace Tyuiu.LachuginAV.Sprint6.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] valueWaitArray = new double[stopValue - startValue + 1];

            valueWaitArray[0] = -19.6;
            

            double[] res = new double[stopValue - startValue + 1];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
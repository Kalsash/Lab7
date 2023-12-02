using Lab7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class NullTests
    {
        [TestMethod]
        public void TestAIsNull()
        {

            double a = 0;
            double b = -4;
            double c = 4;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { 1 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

            Assert.AreEqual(roots.First(), expected_roots.First());

        }

        [TestMethod]
        public void TestAllNull()
        {

            double a = 0;
            double b = 0;
            double c = 0;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

        }

        [TestMethod]
        public void TestBIsNull()
        {
            double a = 1;
            double b = 0;
            double c = -25;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { 5, -5 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);
            double sum = 0;
            double prod = 1;
            foreach (var root in roots)
            {
                sum += root;
                prod *= root;
            }
            Assert.AreEqual(sum, 0);
            Assert.AreEqual(prod, -25);

        }
    }
}

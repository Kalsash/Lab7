using Lab7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class BadNumbersTests
    {
        //[TestMethod]
        public void TestBigNumbers()
        {

            double a = 10000000000;
            double b = -40000000000;
            double c = 40000000000;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { 2 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

            Assert.AreEqual(roots.First(), expected_roots.First());

        }
        [TestMethod]
        public void TestWithoutAB()
        {

            double a = 0;
            double b = 0;
            double c = 777;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

        }

        [TestMethod]
        public void TestTwoBadSolutions()
        {
            double a = 1;
            double b = 3;
            double c = -3;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { -3.7913, 0.79129 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);
            double sum = 0;
            double prod = 1;
            foreach (var root in roots)
            {
                sum += root;
                prod *= root;
            }
            double eps = 0.01;
            Assert.AreEqual(sum, -3.7913+0.79129,eps);
            Assert.AreEqual(prod, -3.7913 * 0.79129, eps);

        }
    }
}

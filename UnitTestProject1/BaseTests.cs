using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Lab7;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class BaseTests
    {
        [TestMethod]
        public void TestOnlySolution()
        {

            double a = 1; 
            double b = -4; 
            double c = 4;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> {2};
            Assert.AreEqual(0,0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

            Assert.AreEqual(roots.First(), expected_roots.First());

        }
        [TestMethod]
        public void TestNoSolution()
        {

            double a = 1;
            double b = 1;
            double c = 4;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> {};
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

        }

        [TestMethod]
        public void TestTwoSolutions()
        {
            double a = 1;
            double b = 10;
            double c = -39;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> {3,-13 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);
            double sum = 0;
            double prod = 1;
            foreach (var root in roots)
            {
                sum += root;
                prod *= root;
            }
            Assert.AreEqual(sum, -10);
            Assert.AreEqual(prod, -39);

        }
    }
}

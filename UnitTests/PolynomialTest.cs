using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Polynomial
{
    [TestClass]
    public class PolynomialUnitTests
    {

	//mostly tests Degree and NumberOfTerms for various operations
	//requires extra checks using ToString()
        [TestMethod]
        public void ToStringReturn0()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual("0", polynomial.ToString());
        }

        [TestMethod]
        public void ToStringReturn3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("3", polynomial.ToString());
        }


        [TestMethod]
        public void ToStringReturn01()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 0);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("0", polynomial.ToString());
        }

        [TestMethod]
        public void ToStringReturnX()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("x", polynomial.ToString());
        }

        [TestMethod]
        public void ToStringReturnNegativeX()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, -1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("-x", polynomial.ToString());
        }

        [TestMethod]
        public void ToStringReturn02()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 0);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("0", polynomial.ToString());
        }

        [TestMethod]
        public void ToString1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("2.1x", polynomial.ToString());
        }

        [TestMethod]
        public void ToString2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(3, 4.2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("4.2x^3", polynomial.ToString());
        }

        [TestMethod]
        public void ToString3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(3, 4.2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(2, 2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual("4.2x^3+2.1x^2", polynomial.ToString());
        }

        [TestMethod]
        public void ToString4()
        {
            Polynomial polynomial = new Polynomial();
            Term term2 = new Term(2, 2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Term term1 = new Term(3, 4.2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            
            Assert.AreEqual("4.2x^3+2.1x^2", polynomial.ToString());
        }

        [TestMethod]
        public void ToString5()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(3, 1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("x^3", polynomial.ToString());
        }

        [TestMethod]
        public void ToString6()
        {
            Polynomial polynomial = new Polynomial();
            Term term2 = new Term(0, 2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Term term1 = new Term(3, 4.2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            
            Assert.AreEqual("4.2x^3+2.1", polynomial.ToString());
        }

        [TestMethod]
        public void ToStringNegative()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, -3.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("-3.1x", polynomial.ToString());
        }

        [TestMethod]
        public void ToStringNegative2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(7, -2.2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("-2.2x^7", polynomial.ToString());
        }

        [TestMethod]
        public void ToStringNegative3()
        {
            Polynomial polynomial = new Polynomial();
            Term term2 = new Term(2, -2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Term term1 = new Term(3, 4.2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);

            Assert.AreEqual("4.2x^3-2.1x^2", polynomial.ToString());
        }

        [TestMethod]
        public void ToStringNegative4()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(3, -4.2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(2, -2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Assert.AreEqual("-4.2x^3-2.1x^2", polynomial.ToString());
        }

        [TestMethod]
        public void ToStringNegative5()
        {
            Polynomial polynomial = new Polynomial();
            Term term2 = new Term(2, 2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Term term1 = new Term(3, -4.2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);

            Assert.AreEqual("-4.2x^3+2.1x^2", polynomial.ToString());
        }

        [TestMethod]
        public void ToStringNegative6()
        {
            Polynomial polynomial = new Polynomial();
            Term term2 = new Term(0, -2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Term term1 = new Term(3, 4.2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);

            Assert.AreEqual("4.2x^3-2.1", polynomial.ToString());
        }

        [TestMethod]
        public void DegreeReturn0()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual(0, polynomial.Degree);
        }

        [TestMethod]
        public void DegreeUsesAddTerm()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual(1, polynomial.Degree);
        }

        [TestMethod]
        public void DegreeUsesAddTerm2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(2, 2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual(2, polynomial.Degree);
        }

        [TestMethod]
        public void DegreeUsesAddTerm3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual(2, polynomial.Degree);
        }

        /*[TestMethod]
        public void ToStringExpectFail()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);

            Term term2 = new Term(4, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Assert.AreEqual("foo", polynomial.ToString());
        }*/

        [TestMethod]
        public void AddTermAndToString()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 0.0);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("0", polynomial.ToString());

        }

        [TestMethod]
        public void NumberOfTerms()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual(0, polynomial.NumberOfTerms);
            Term term1 = new Term(0, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual(1, polynomial.NumberOfTerms);

            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual(2, polynomial.NumberOfTerms);
        }

        [TestMethod]
        public void AddTermSimplify()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual(0, polynomial.NumberOfTerms);
            Term term1 = new Term(0, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual(1, polynomial.NumberOfTerms);

            Term term2 = new Term(0, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual(1, polynomial.NumberOfTerms);
        }

        [TestMethod]
        public void AddTermSimplify2Diff()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual(0, polynomial.NumberOfTerms);
            Term term1 = new Term(0, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual(1, polynomial.NumberOfTerms);

            Term term2 = new Term(0, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual("5.1", polynomial.ToString().Substring(0,3));
        }

        [TestMethod]
        public void AddTermSimplifySame()
        {
            Polynomial polynomial = new Polynomial();
            Assert.AreEqual(0, polynomial.NumberOfTerms);
            Term term1 = new Term(2, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual(1, polynomial.NumberOfTerms);

            Term term2 = new Term(2, -2.1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Assert.AreEqual("0", polynomial.ToString());
        }

        [TestMethod]
        public void AddTermSimplify3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("x", polynomial.ToString());
        }

        [TestMethod]
        public void AddTerm0()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(1, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("2.1x", polynomial.ToString());
        }

        [TestMethod]
        public void AddTerm1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2.1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("2.1", polynomial.ToString());
        }

        [TestMethod]
        public void AddTerm2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 0);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("0", polynomial.ToString());
        }

        [TestMethod]
        public void AddTerm3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("3x^2", polynomial.ToString());
        }

        [TestMethod]
        public void AddTerm4()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, -3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("-3x^2", polynomial.ToString());
        }

        [TestMethod]
        public void AddTerm5()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, -3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("-3", polynomial.ToString());
        }

        [TestMethod]
        public void AddTerm6()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Assert.AreEqual("2", polynomial.ToString());
        }

        [TestMethod]
        public void AddPoly1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(1, polynomialSum.Degree);
            Assert.AreEqual("6x+4", polynomialSum.ToString());
        }

        [TestMethod]
        public void AddPoly2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(3, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(2, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(3, polynomialSum.Degree);
            Assert.AreEqual("2x^3+3x^2+3x+2", polynomialSum.ToString());
        }

        [TestMethod]
        public void AddPoly3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(1, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(2, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(3, polynomialSum.NumberOfTerms);
            Assert.AreEqual(2, polynomialSum.Degree);
        }

        [TestMethod]
        public void AddPolyNegative()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, -3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(1, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(2, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(3, polynomialSum.NumberOfTerms);
            Assert.AreEqual(2, polynomialSum.Degree);
            Assert.AreEqual("3x^2-x+2", polynomialSum.ToString());

        }

        [TestMethod]
        public void AddPolyNegative2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(4, -3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(1, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(2, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(4, polynomialSum.Degree);
            Assert.AreEqual("-3x^4+3x^2+2x+2", polynomialSum.ToString());

        }

        [TestMethod]
        public void AddPolyNegative3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(4, -3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(1, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(1, polynomialSum.Degree);
            Assert.AreEqual("2x+2", polynomialSum.ToString());

        }

        [TestMethod]
        public void AddPolyNegative4()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(4, -3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(1, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, -3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(3, polynomialSum.NumberOfTerms);
            Assert.AreEqual(4, polynomialSum.Degree);
            Assert.AreEqual("-6x^4+2x+2", polynomialSum.ToString());

        }

        [TestMethod]
        public void AddPolyNegative5()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, -3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(1, -2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(3, polynomialSum.NumberOfTerms);
            Assert.AreEqual(4, polynomialSum.Degree);
            Assert.AreEqual("3x^4-5x+2", polynomialSum.ToString());

        }

        [TestMethod]
        public void AddPolyEmpty()
        {
            Polynomial polynomial = new Polynomial();

            Polynomial polynomial2 = new Polynomial();

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(0, polynomialSum.NumberOfTerms);
            Assert.AreEqual(0, polynomialSum.Degree);

        }

        [TestMethod]
        public void AddPolyEmpty2()
        {
            Polynomial polynomial = new Polynomial();

            Polynomial polynomial2 = new Polynomial();

            Term term3 = new Term(1, -2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(4, polynomialSum.Degree);
            Assert.AreEqual("3x^4-2x", polynomialSum.ToString());

        }

        [TestMethod]
        public void AddPolyEmpty3()
        {
            Polynomial polynomial = new Polynomial();

            Polynomial polynomial2 = new Polynomial();

            Term term3 = new Term(1, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial2, polynomial);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(4, polynomialSum.Degree);
            Assert.AreEqual("3x^4+2x", polynomialSum.ToString());

        }

        [TestMethod]
        public void AddPolyEmpty4()
        {
            Polynomial polynomial = new Polynomial();

            Polynomial polynomial2 = new Polynomial();

            Term term3 = new Term(1, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(4, polynomialSum.Degree);
            Assert.AreEqual("3x^4+2x", polynomialSum.ToString());

        }

        [TestMethod]
        public void SubPoly0()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(0, polynomialSum.NumberOfTerms);
            Assert.AreEqual(0, polynomialSum.Degree);
            Assert.AreEqual("0", polynomialSum.ToString());
        }

        [TestMethod]
        public void SubPolyNegative()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, -2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, -3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(1, polynomialSum.Degree);
            Assert.AreEqual("6x+4", polynomialSum.ToString());
        }

        [TestMethod]
        public void SubPolyNegative2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, -2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, -3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, -2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, -3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(0, polynomialSum.NumberOfTerms);
            Assert.AreEqual(0, polynomialSum.Degree);
            Assert.AreEqual("0", polynomialSum.ToString());
        }

        [TestMethod]
        public void SubPolyNegative3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, -2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, -3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Term term5 = new Term(3, -3);
            polynomial.AddTerm(term5.Coefficient, term5.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 3);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, 3);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(3, polynomialSum.NumberOfTerms);
            Assert.AreEqual(3, polynomialSum.Degree);
            Assert.AreEqual("-3x^3-6x-5", polynomialSum.ToString());
        }

        [TestMethod]
        public void SubPoly1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(1, polynomialSum.Degree);
        }

        [TestMethod]
        public void SubPoly2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(2, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(1, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(3, polynomialSum.NumberOfTerms);
            Assert.AreEqual(2, polynomialSum.Degree);
        }

        [TestMethod]
        public void SubPoly3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(2, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(4, polynomialSum.Degree);
            Assert.AreEqual("-9x^4-2x^2+3x+3", polynomialSum.ToString());
        }

        [TestMethod]
        public void SubPolyEmpty1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(1, polynomialSum.Degree);
        }

        [TestMethod]
        public void SubPolyEmpty2()
        {
            Polynomial polynomial = new Polynomial();

            Polynomial polynomial2 = new Polynomial();

            Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
            Assert.AreEqual(0, polynomialSum.NumberOfTerms);
            Assert.AreEqual(0, polynomialSum.Degree);
            Assert.AreEqual("0", polynomialSum.ToString());
        }

        [TestMethod]
        public void SubPolyEmpty3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 2);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();

            Polynomial polynomialSum = Polynomial.Subtract(polynomial2, polynomial);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(1, polynomialSum.Degree);
            Assert.AreEqual("-2x-3", polynomialSum.ToString());
        }

        [TestMethod]
        public void SubPolyEmptyNegative()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, -3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, -2);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();

            Polynomial polynomialSum = Polynomial.Subtract(polynomial2, polynomial);
            Assert.AreEqual(2, polynomialSum.NumberOfTerms);
            Assert.AreEqual(1, polynomialSum.Degree);
            Assert.AreEqual("2x+3", polynomialSum.ToString());
        }


        [TestMethod]
        public void NegateWithAdd()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = Polynomial.Negate(polynomial);

            Polynomial polynomialSum = Polynomial.Add(polynomial, polynomial2);
            Assert.AreEqual(0, polynomialSum.NumberOfTerms);
            Assert.AreEqual(0, polynomialSum.Degree);
            Assert.AreEqual("0", polynomialSum.ToString());
        }

        [TestMethod]
        public void Negate1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 1);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            polynomial = Polynomial.Negate(polynomial);

            Assert.AreEqual(2, polynomial.NumberOfTerms);
            Assert.AreEqual(1, polynomial.Degree);
            Assert.AreEqual("-x-3", polynomial.ToString());
        }

        [TestMethod]
        public void NegateNegative()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, -1);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(2, -3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            polynomial = Polynomial.Negate(polynomial);

            Assert.AreEqual(2, polynomial.NumberOfTerms);
            Assert.AreEqual(2, polynomial.Degree);
            Assert.AreEqual("3x^2+1", polynomial.ToString());
        }


        [TestMethod]
        public void NegateBoth()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(0, -2);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(2, 4);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            polynomial = Polynomial.Negate(polynomial);

            Assert.AreEqual(2, polynomial.NumberOfTerms);
            Assert.AreEqual(2, polynomial.Degree);
            Assert.AreEqual("-4x^2+2", polynomial.ToString());
        }

        [TestMethod]
        public void NegateEmpty()
        {
            Polynomial polynomial = new Polynomial();

            polynomial = Polynomial.Negate(polynomial);

            Assert.AreEqual(0, polynomial.NumberOfTerms);
            Assert.AreEqual(0, polynomial.Degree);
            Assert.AreEqual("0", polynomial.ToString());
        }



        [TestMethod]
        public void Multiply1()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(6, polynomialSum.Degree);
            Assert.AreEqual("27x^6+27x^5+6x^2+6x", polynomialSum.ToString());
        }

        [TestMethod]
        public void MultiplyNegative()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, -2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, -9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(6, polynomialSum.Degree);
            Assert.AreEqual("-27x^6-27x^5-6x^2-6x", polynomialSum.ToString());
        }

        [TestMethod]
        public void MultiplyNegative2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, -9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(6, polynomialSum.Degree);
            Assert.AreEqual("-27x^6-27x^5+6x^2+6x", polynomialSum.ToString());
        }

        [TestMethod]
        public void MultiplyNegative3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, -3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, -2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, -9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(6, polynomialSum.Degree);
            Assert.AreEqual("27x^6-27x^5+6x^2-6x", polynomialSum.ToString());
        }

        [TestMethod]
        public void MultiplyNegative4()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, -3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, -3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, -2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(4, -9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(6, polynomialSum.Degree);
            Assert.AreEqual("27x^6+27x^5+6x^2+6x", polynomialSum.ToString());
        }

        [TestMethod]
        public void Multiply2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(12, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(80, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(4, polynomialSum.NumberOfTerms);
            Assert.AreEqual(92, polynomialSum.Degree);
        }

        [TestMethod]
        public void Multiply3()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(12, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(2, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Term term = new Term(1, 3);
            polynomial.AddTerm(term.Coefficient, term.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(80, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(6, polynomialSum.NumberOfTerms);
            Assert.AreEqual(92, polynomialSum.Degree);
        }

        [TestMethod]
        public void Multiply4()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(12, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(2, 7.01);
            polynomial.AddTerm(term2.Coefficient, term2.Power);
            Term term = new Term(1, 4.21);
            polynomial.AddTerm(term.Coefficient, term.Power);

            Polynomial polynomial2 = new Polynomial();
            Term term3 = new Term(0, 2);
            polynomial2.AddTerm(term3.Coefficient, term3.Power);
            Term term4 = new Term(6, 9);
            polynomial2.AddTerm(term4.Coefficient, term4.Power);
            Term term6 = new Term(4, 3.4);
            polynomial2.AddTerm(term6.Coefficient, term6.Power);

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(9, polynomialSum.NumberOfTerms);
            Assert.AreEqual(18, polynomialSum.Degree);
        }

        [TestMethod]
        public void MultiplyEmpty()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, -3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();

            Polynomial polynomialSum = Polynomial.Multiply(polynomial, polynomial2);
            Assert.AreEqual(0, polynomialSum.NumberOfTerms);
            Assert.AreEqual(0, polynomialSum.Degree);
            Assert.AreEqual("0", polynomialSum.ToString());
        }

        [TestMethod]
        public void MultiplyEmpty2()
        {
            Polynomial polynomial = new Polynomial();
            Term term1 = new Term(2, 3);
            polynomial.AddTerm(term1.Coefficient, term1.Power);
            Term term2 = new Term(1, 3);
            polynomial.AddTerm(term2.Coefficient, term2.Power);

            Polynomial polynomial2 = new Polynomial();

            Polynomial polynomialSum = Polynomial.Multiply(polynomial2, polynomial);
            Assert.AreEqual(0, polynomialSum.NumberOfTerms);
            Assert.AreEqual(0, polynomialSum.Degree);
            Assert.AreEqual("0", polynomialSum.ToString());
        }
    }
}

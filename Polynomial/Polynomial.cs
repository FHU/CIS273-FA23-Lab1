using System;
namespace Polynomial
{

	// 4x^3 + 9x - 5
	public class Polynomial
	{
		LinkedList<Term> terms;

		public int NumberOfTerms => terms.Count;

		// TODO
		public int Degree
		{
			get
			{
				if (NumberOfTerms == 0)
					return 0;

				return terms.First.Value.Power;
			}

		}
		public Polynomial()
		{
			terms = new LinkedList<Term>();
		}

		// TODO
		public void AddTerm(double coeff, int power)
		{

		}

        public override string ToString()
        {
			string result = "";

			var currentNode = terms.First;

			while( currentNode != null)
			{
				//do work
				result += currentNode.Value.ToString() + "+";
				
				currentNode = currentNode.Next;
			}

			return result;
        }


        // TODO
        public static Polynomial Add(Polynomial p1, Polynomial p2)
		{
			return null;
		}

		// TODO
		public static Polynomial Subtract(Polynomial p1, Polynomial p2)
		{
			return null;
		}

		// TODO
		public static Polynomial Negate(Polynomial p)
		{
            return null;
        }

		// TODO
		public static Polynomial Multiply(Polynomial p1, Polynomial p2)
		{
			return null;
		}



    }
}


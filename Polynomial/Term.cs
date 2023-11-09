using System;
namespace Polynomial
{
	public class Term
	{
		public double Coefficient { get; set; }

		public int Power { get; set; }

		public Term(int power, double coefficient)
		{
			Power = power;
			Coefficient = coefficient;
		}

        public override string ToString()
        {
			if(Power == 0)
			{
                return $"{Coefficient}";
            }

			if (Power == 1)
			{
                return $"{Coefficient}x";
            }

			return $"{Coefficient}x^{Power}";
        }
    }
}


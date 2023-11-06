using System;
namespace SOLIDPrinciples.LiskovSubstitution
{
	public class OldImplementationWithCarExample
	{
        public OldImplementationWithCarExample()
        {
            Car bmw = new Coupe();
            Car vw = new Coupe();
            Car f1 = new Formula1();

            var allCars = new List<Car> { bmw, vw, f1 };

            allCars.ForEach(x => Console.WriteLine(x.GetCabinWidth()));
        }

		public interface Car
		{
			double GetCabinWidth();
		}

        public interface RacingCar : Car
        {
            double GetCockpitWidth();
        }

        public class Coupe : Car
        {
            public double GetCabinWidth()
            {
				return 100;
            }
        }

        public class Formula1 : RacingCar
        {
            public double GetCabinWidth()
            {
                throw new NotImplementedException();
            }

            public double GetCockpitWidth()
            {
                return 100;
            }
        }
    }
}


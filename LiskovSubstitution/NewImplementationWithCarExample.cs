using System;
namespace SOLIDPrinciples.LiskovSubstitution
{
	public class NewImplementationWithCarExample
	{
		public NewImplementationWithCarExample()
		{
            Vehicle bmw = new Coupe();
            Vehicle vw = new Coupe();
            Vehicle f1 = new Racing();

            var allCars = new List<Vehicle> { bmw, vw, f1 };

            allCars.ForEach(x => Console.WriteLine(x.GetInteriorWidth()));
        }

		public abstract class Vehicle
		{
			public abstract double GetInteriorWidth();
		}

        public class Coupe : Vehicle
        {
            public override double GetInteriorWidth()
            {
				return GetCabinWidth();
            }

			private double GetCabinWidth ()
			{
				return 100;
			}
        }

        public class Racing : Vehicle
        {
            public override double GetInteriorWidth()
            {
                return GetCockpitWidth();
            }

            private double GetCockpitWidth()
            {
                return 80;
            }
        }
    }
}


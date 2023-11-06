using System;
using System.Diagnostics;

namespace SOLIDPrinciples.LiskovSubstitution
{
	public class OldImplementation
	{
		public OldImplementation()
		{
            Apple apple = new Orange();
            Debug.WriteLine(apple.GetColor());
        }

        public class Apple
        {
            public virtual string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Apple
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    }
}


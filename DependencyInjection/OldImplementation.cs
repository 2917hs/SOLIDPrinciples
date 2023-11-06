using System;
namespace SOLIDPrinciples.DependencyInjection
{
	public class OldImplementation
	{
		public OldImplementation()
		{
		}

        public interface ICustomerDataAccess
        {
            string GetCustomerName(int id);
        }

        public class CustomerDataAccess : ICustomerDataAccess
        {
            public string GetCustomerName(int id)
            {
                return "Customer Name";
            }
        }

        public class CustomerBusinessLogic
        {
            ICustomerDataAccess _customerDataAccess = new CustomerDataAccess();

            public CustomerBusinessLogic()
            {
            }

            public string GetCustomerName(int id)
            {
                return _customerDataAccess.GetCustomerName(id);
            }
        }
    }
}


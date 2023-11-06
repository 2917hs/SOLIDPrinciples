using System;
namespace SOLIDPrinciples.DependencyInjection
{
	public class NewImplementation
	{
		public NewImplementation()
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

		public class DataAccessFactory
		{
			public static ICustomerDataAccess CustomerDataAccessObject()
			{
				return new CustomerDataAccess();
			}
		}

		public class CustomerBusinessLogic
		{
			ICustomerDataAccess _customerDataAccess;

			public CustomerBusinessLogic()
			{
				_customerDataAccess = DataAccessFactory.CustomerDataAccessObject();
			}

			public string GetCustomerName(int id)
			{
				return _customerDataAccess.GetCustomerName(id);
			}
		}
    }
}


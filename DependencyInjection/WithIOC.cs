using System;
namespace SOLIDPrinciples.DependencyInjection
{
	public class WithIOC
	{
		public WithIOC()
		{
            var customer = new CustomerBusinessLogic(new CustomerDataAccess());
            Console.WriteLine( customer.GetCustomerName(1));
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

            public CustomerBusinessLogic(ICustomerDataAccess customerDataAccess)
            {
                _customerDataAccess = customerDataAccess;
            }

            public string GetCustomerName(int id)
            {
                return _customerDataAccess.GetCustomerName(id);
            }
        }
    }
}


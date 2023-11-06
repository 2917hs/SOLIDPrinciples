using System;
namespace SOLIDPrinciples.SingleResponsibility
{
	public class NewImplementation
	{
        public NewImplementation()
		{
		}

        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            //_userRepository.Insert("INSERT INTO [...]");

            //_emailService.Send("smtp.myhost.com");
        }
    }
}


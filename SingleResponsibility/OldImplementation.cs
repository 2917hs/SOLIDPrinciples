using System.Net.Mail;
using Microsoft.Data.SqlClient;

namespace SOLIDPrinciples.SingleResponsibility
{
    public class OldImplementation
	{
		public OldImplementation()
		{

		}

        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [...]"); 

            SmtpClient client = new SmtpClient("smtp.myhost.com");
            client.Send(new MailMessage()); 
        }
    }
}


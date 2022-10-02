namespace Garage.Models
{
    public class AutorizationRequest
    {
        public string Autorization(string login, string pwd)
        {
            if (login != null && login == "login" && pwd.Length >= 8 && pwd != null)
            {
                return "Verification accepted";
            }
            else
            {
                return "try again";
            }
        }
    }
}

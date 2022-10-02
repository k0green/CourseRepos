using Garage.Models;
using Garage.Services;

namespace GarageTest
{
    public class AutorisationRequestTest
    {
        private readonly AutorizationRequest _sut = new AutorizationRequest(); 
        [Fact]
        public void AutorisationTest_ShouldReturnVerifyAccepted()
        {
            var login = "login";
            var pwd = "12345678";
            var result = _sut.Autorization(login, pwd);
            Assert.Equal(result, "Verification accepted");
        }
        [Fact]
        public void AutorisationTest_ShouldReturnTryAgain()
        {
            var login = "email";
            var pwd = "1234";
            var result = _sut.Autorization(login, pwd);
            Assert.Equal(result, "try again");
        }
    }
}
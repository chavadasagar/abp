using System.Threading.Tasks;
using Project.web.Models.TokenAuth;
using Project.web.Web.Controllers;
using Shouldly;
using Xunit;

namespace Project.web.Web.Tests.Controllers
{
    public class HomeController_Tests: webWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
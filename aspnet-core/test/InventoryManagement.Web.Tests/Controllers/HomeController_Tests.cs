using System.Threading.Tasks;
using InventoryManagement.Models.TokenAuth;
using InventoryManagement.Web.Controllers;
using Shouldly;
using Xunit;

namespace InventoryManagement.Web.Tests.Controllers
{
    public class HomeController_Tests: InventoryManagementWebTestBase
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
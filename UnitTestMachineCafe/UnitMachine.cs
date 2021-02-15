using Infrastructure;
using Machine_Cafe.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Moq;
using Services;

namespace UnitTestMachineCafe
{
    [TestClass]
    public class UnitMachine
    {

        [TestMethod]
        public void Get_Utilisateur_OrNull()
        {
            decimal badge = 1345784;
            var mockService = new Mock<ImachineService>();
            var mockLogger = new Mock<ILogger<UtilisateurController>>();
            var userController = new UtilisateurController(mockLogger.Object, mockService.Object);

           var result = userController.Get(badge);

            Assert.AreEqual(result.Value,null);
        }
    }
}

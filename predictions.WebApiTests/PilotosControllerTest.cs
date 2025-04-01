using Microsoft.AspNetCore.Mvc;
using predictions.WebApi.Controllers;

namespace predictions.WebApiTests;

[TestClass]
public class PilotosControllerTests
{
    [TestMethod]
    public void GetAllPilotos_ReturnsHelloWorld()
    {
        var controller = new PilotosController();

        var result = controller.GetAllPilotos();

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult);
        Assert.AreEqual(200, okResult.StatusCode);
        Assert.AreEqual("helloworld", okResult.Value);
    }
}

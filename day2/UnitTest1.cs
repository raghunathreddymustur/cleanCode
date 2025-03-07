namespace TemplateEngine.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("Hello Riya","")]
    [TestCase("Hello Riya", "Siemens")]
    public void Test1(string name,string companyName)
    {
        //Arrange
        TemplateEngine templateEngine = new TemplateEngine();
        templateEngine.SetTemplate(name);
        templateEngine.SetVariable(companyName);

        //Act
        var res = templateEngine.Evaluate();

        //Assert
        Assert.That(name+companyName,Is.EqualTo(res));
    }
}
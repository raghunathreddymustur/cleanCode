namespace TemplateEngine;

public class TemplateEngine
{
    private string myName = "Hello Riya";
    private string myCompanyName = "Siemens";
    private Dictionary<string, string> myVariables = new Dictionary<string, string>();
    public TemplateEngine()
    {
        
    }
    public string Evaluate()
    {
        return myName+myCompanyName;
    }

    public void SetTemplate(string name)
    {
        this.myName = name;
    }

    public void SetVariable(string companyName)
    {
        this.myCompanyName = companyName;
    }
}

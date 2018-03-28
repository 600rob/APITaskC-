using TechTalk.SpecFlow;

namespace WebApiCodeTest.Steps
{
    [Binding]
    public class CommonSteps : StepsBase
    {
        [When(@"(?i)the response is received")]
        public void WhenIGetTheResponseBackFromApi()
        {
            Response = Client.Execute<dynamic>(Request);
        }
    }
}

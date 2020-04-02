using System;
using TechTalk.SpecFlow;

namespace ReqresAPITests
{
    [Binding]
    public class GetUserListSteps
    {
        [Then(@"I get the list of users")]
        public void ThenIGetTheListOfUsers()
        {
            //ScenarioContext.Current.Pending();
            HelperClass helper = new HelperClass();
            var response = helper.CreateGetRequest();
        }
    }
}

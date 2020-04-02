using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ReqresAPITests
{
    [Binding]
    public class UserRegistrationSteps
    {
        [Given(@"I Navigate to the Registration page of reqres")]
        public void GivenINavigateToTheRegistrationPageOfReqres()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Register a user with Username and Password Registration Page")]
        public void WhenIRegisterAUserWithUsernameAndPasswordRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Unsucessfully Register a user with Username and BLANK on the Registration Page")]
        public void WhenIUnsucessfullyRegisterAUserWithUsernameAndBLANKOnTheRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I Should See Message Response(.*)Msg on the Registration Page")]
        public void ThenIShouldSeeMessageResponseMsgOnTheRegistrationPage(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I Should See Error Message errorMsg on the Registration Page")]
        public void ThenIShouldSeeErrorMessageErrorMsgOnTheRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

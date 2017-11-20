using System;
using TechTalk.SpecFlow;

namespace RPNCalculator
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered \+ into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator()
        {
            //ScenarioContext.Current.Pending();
            Program objProgram = new Program();
            objProgram.GetInput();
        }
        
        [When(@"I press Enter")]
        public void WhenIPressEnter()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) \+ (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FlightSchedule.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class FlightGenerationFeature : Xunit.IClassFixture<FlightGenerationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "FlightGeneration.feature"
#line hidden
        
        public FlightGenerationFeature(FlightGenerationFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FlightGeneration", "\tIn order to generate flights easily and time-efficient\r\n\tAs an flight agency man" +
                    "ager\r\n\tI want to be able to generate batch flights", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Generate flights")]
        [Xunit.TraitAttribute("FeatureTitle", "FlightGeneration")]
        [Xunit.TraitAttribute("Description", "Generate flights")]
        [Xunit.TraitAttribute("Category", "API")]
        [Xunit.TraitAttribute("Category", "UI")]
        public virtual void GenerateFlights()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate flights", null, new string[] {
                        "API",
                        "UI"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "From",
                        "To",
                        "FlightNumber"});
            table1.AddRow(new string[] {
                        "IKA",
                        "DXB",
                        "2018-09-30",
                        "2018-10-15",
                        "WS-2130"});
#line 8
 testRunner.Given("I reserved a flight from airline with following information", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "DayOfWeek",
                        "DepartureTime",
                        "ArrivalTime"});
            table2.AddRow(new string[] {
                        "Monday",
                        "09:00",
                        "10:30"});
            table2.AddRow(new string[] {
                        "Wednesday",
                        "20:30",
                        "22:00"});
#line 11
 testRunner.And("The flight has the following weekly timetable", ((string)(null)), table2, "And ");
#line 15
 testRunner.When("I generate the flights", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "DepartDate",
                        "ArriveDate",
                        "FlightNumber",
                        "Origin",
                        "Destination"});
            table3.AddRow(new string[] {
                        "2018-10-01 09:00",
                        "2018-10-01 10:30",
                        "WS-2130",
                        "IKA",
                        "DXB"});
            table3.AddRow(new string[] {
                        "2018-10-03 20:30",
                        "2018-10-03 22:00",
                        "WS-2130",
                        "IKA",
                        "DXB"});
            table3.AddRow(new string[] {
                        "2018-10-08 09:00",
                        "2018-10-08 10:30",
                        "WS-2130",
                        "IKA",
                        "DXB"});
            table3.AddRow(new string[] {
                        "2018-10-10 20:30",
                        "2018-10-10 22:00",
                        "WS-2130",
                        "IKA",
                        "DXB"});
            table3.AddRow(new string[] {
                        "2018-10-15 09:00",
                        "2018-10-15 10:30",
                        "WS-2130",
                        "IKA",
                        "DXB"});
#line 16
 testRunner.Then("The following flights should be generated", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                FlightGenerationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                FlightGenerationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

using System;
using System.Net;
using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using RestSharp;
using TechTalk.SpecFlow;
using NJsonSchema;
using JsonSchema = NJsonSchema.JsonSchema;


namespace ApiTestSpecFlow
{
    [Binding] 
    class SwapiApiFeatureSteps
    {
        private CustomScenarioContext _customScenarioContext;
        private RestClient _client = new RestClient();

        public SwapiApiFeatureSteps(CustomScenarioContext customScenarioContext)
        {
            _customScenarioContext = customScenarioContext;
            _client = new RestClient
            {
                BaseUrl = new Uri("https://swapi.dev/api/vehicles/")
            };
        }


        [Given(@"I send GET Request to endponit ""(.*)""")]
        public void GivenISendGETRequestToEndponit(string p0)
        {
            var request = new RestRequest(Method.GET);

            _customScenarioContext.restResponse = _client.Execute(request);

        }
        
        [When(@"the request is succesfull")]
        public void WhenTheRequestIsSuccesfull()
        {
            _customScenarioContext.restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        
        [Then(@"compare actual response to expected scema")]
        public void ThenCompareActualResponseToExpectedScema()
        {
            var jsonObject = JsonConvert.DeserializeObject(_customScenarioContext.restResponse.Content);
            switch (jsonObject)
            {
                case Vehicles vehicles:
                    var schema = JsonSchema.FromType<Vehicles>();
                    var errors = schema.Validate(_customScenarioContext.restResponse.Content);
                    errors.Should().BeEmpty();
                    break;
                default:
                    break;
            }
        }
    }
}

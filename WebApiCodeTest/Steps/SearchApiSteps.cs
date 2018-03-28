using System.Net;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace WebApiCodeTest.Steps
{
    [Binding]
    public class SearchApiSteps : StepsBase
    {
        private const string SearchV1Path = "/product/search/V1/";
        private const string Accept = "application/json";
        private const string Store = "1";
        private const string Lang = "en";
        private const string Currency = "GBP";
        private const string OffSet = "0";
        private const string Q = "";
        private const string Limit = "10";

        [Given(@"(?i)I search for (.*) items")]
        public void GivenISearchForItems(string searchTerm)
        {
            Request = new RestRequest(Method.GET)
            {
                Resource = SearchV1Path
            };

            Request.AddHeader("Accept", Accept);
            Request.AddParameter("store", Store);
            Request.AddParameter("lang", Lang);
            Request.AddParameter("currency", Currency);
            Request.AddParameter("offset", OffSet);
            Request.AddParameter("q", Q);
            Request.AddParameter("limit", Limit);
        }

        [Then(@"(?i)I will receive an (.*) response")]
        public void ThenIWillReceiveAnResponse(HttpStatusCode statusCode)
        {
            Assert.That(Response.ResponseStatus, Is.EqualTo(statusCode));
        }
    }
}   
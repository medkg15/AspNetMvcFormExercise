using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace AspNetMvcData.Callouts
{
    public class MockCalloutQuery : ICalloutQuery
    {
        private static readonly Random Random = new Random();

        public IEnumerable<Callout> GetCallouts()
        {
            var faker = new Faker<Callout>()
                .RuleFor(r => r.Title, f => f.Commerce.Department())
                .RuleFor(r => r.ImageUrl, f => f.Image.PicsumUrl(320, 240))
                .RuleFor(r => r.LinkUrl, f => f.Internet.UrlWithPath());

            return faker.Generate(Random.Next() % 10 + 1);
        }
    }
}

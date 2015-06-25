using Fact.Faker.Utils;
using System;
using System.Text;

namespace Fact.Faker
{
    public class Price
    {
        public static decimal Value => Convert.ToDecimal("#####.##m".Numerify());
    }
}
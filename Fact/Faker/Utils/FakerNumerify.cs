using System.Linq;
using System.Text;

namespace Fact.Faker.Utils
{
    internal static class FakerNumerify
    {
        public static string Numerify(this string value)
        {
            var number = new StringBuilder();

            foreach (var item in value.ToList())
            {
                number.Append(item.ToString().Replace("#", 10.Randomize().ToString()));
            }

            return number.ToString();
        }
    }
}

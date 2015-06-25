using Fact.Faker.Utils;

namespace Fact.Faker.US
{
    public class ColorUS
    {
        public static string Name => COLORS_NAME.Rand();

        private static string[] COLORS_NAME =
        {
            "aqua","black","blue","brown","fuchsia","gray","green","lime","maroon","navy","olive","orange","pink","purple","red",
            "silver","teal","white","yellow"
        };
    }
}

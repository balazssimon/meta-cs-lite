using Xunit;

namespace MetaDslx.Languages.MetaModel.Tests
{
    using MetaDslx.Modeling;

    public class HusbandWifeTest : MetaModelTests
    {
        private const string MetaModelCode = @"
class Husband
{
    Wife Wife opposite Wife.Husband;
}

class Wife
{
    Husband Husband opposite Husband.Wife;
}
";

        [Fact]
        public void TestHusbandToWife()
        {
            dynamic f = Factory(MetaModelCode);
            var husband = f.Husband();
            var wife = f.Wife();
            husband.Wife = wife;
            Assert.Equal(wife, husband.Wife);
            Assert.Equal(husband, wife.Husband);
        }
    }
}
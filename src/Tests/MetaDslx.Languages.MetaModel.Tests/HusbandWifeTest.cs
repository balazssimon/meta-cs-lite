using Xunit;

namespace MetaDslx.Languages.MetaModel.Tests
{
    using MetaDslx.Modeling;

    public class HusbandWifeTest : MetaModelTests
    {
        private const string MetaModelCode = @"
class Husband
{
    Wife WifeX opposite Wife.HusbandX;
}

class Wife
{
    Husband HusbandX opposite Husband.WifeX;
}
";

        [Fact]
        public void TestHusbandToWife()
        {
            dynamic f = Factory(MetaModelCode);
            var husband = f.Husband();
            var wife = f.Wife();
            husband.WifeX = wife;
            Assert.Equal(wife, husband.WifeX);
            Assert.Equal(husband, wife.HusbandX);
        }
    }
}
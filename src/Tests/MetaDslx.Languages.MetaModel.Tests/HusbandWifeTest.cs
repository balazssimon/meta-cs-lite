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
            var model = new Model();
            dynamic f = Factory(MetaModelCode, model);
            var husband = f.Husband();
            var wife = f.Wife();
            husband.WifeX = wife;
            Assert.Equal(wife, husband.WifeX);
            Assert.Equal(husband, wife.HusbandX);
        }
    }
}
using Xunit;

namespace Metaverso
{

    public class SistemaTest
    {

        [Theory]
        [InlineData(3,"Meta ")]
        [InlineData(5,"Verso ")]
        [InlineData(15,"Metaverso ")]
        [InlineData(1, "1 ")]
        public void SaludoTest(int num, string esperado)
        {
            var sis = new Sistema();
            var result = sis.Meta(num);
            Assert.Equal(result, esperado);
        }
       
    }
}

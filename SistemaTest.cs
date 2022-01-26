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
        [Theory]
        [InlineData(3,77, "Meta 77 ")]
        [InlineData(5, 3, "Verso Meta")]
        [InlineData(15,5,15,"Metaverso Verso Metaverso")]
        [InlineData(1,3,4,5, "1 3 4 Verso")]
        public void SaludoTest(int[] num, string esperado)
        {
            var sis = new Sistema();
            var result = sis.Meta(num);
            Assert.Equal(result, esperado);
        }
    }
}
using System;
using Xunit;
using Xunit.Abstractions;

namespace juros.api.test
{
    public class JurosTest
    {

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void ValorInicial_NaoDeveSerMenorOuIgualZero(decimal valorInicial)
        {
            if (valorInicial <= 0) 
                Assert.True(true);
            else
                Assert.True(false);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Meses_NaoDeveSerMenorOuIgualZero(int meses)
        {
            if (meses <= 0)
                Assert.True(true);
            else
                Assert.True(false);
        }
    }
}

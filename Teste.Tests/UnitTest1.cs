using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste;

namespace Teste.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void TestApenasLetras_CasoValido()
        {
            // Arrange
            Form1 form = new Form1();           

            // Act
            bool resultado = form.ApenasLetras("NomeValido");

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestApenasLetras_CasoInvalido()
        {
            // Arrange
            Form1 form = new Form1();

            // Act
            bool resultado = form.ApenasLetras("123 Inválido");

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TestEmailValido_CasoValido()
        {
            // Arrange
            Form1 form = new Form1();

            // Act
            bool resultado = form.EmailValido("email@dominio.com");

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestEmailValido_CasoInvalido()
        {
            // Arrange
            Form1 form = new Form1();

            // Act
            bool resultado = form.EmailValido("emailinvalido");

            // Assert
            Assert.IsFalse(resultado);
        }
    }
}

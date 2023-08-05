using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebasUnitariasCalc;
namespace CalculadoraTest
{

    [TestClass]
    public class UnitTest1
    {
        [DataRow(4, 4, 8)]
        [DataRow(4, 0, 4)]
        [DataRow(0, 0, 0)]
        [DataRow(-1, -3, -4)]
        [DataRow(4,-1,3)]
        [TestMethod]
        public void Suma_retornaValor(double a, double b, double esperado)
        {
          /* //Arrange
            double a = 4.0;
            double b = 4.0;
            double esperado = 8;*/

            //Act
            double actual = clsCalculadora.suma(a,b);


            //Assert
            Assert.AreEqual(esperado, actual);
        }


        [DataRow(1, 4, 1)]
        [DataRow(4, 0, -1)]
        [DataRow(0, 0, 0)]
        [DataRow(-1, -4, 0.25)]
        [DataRow(1, -1, -4)]
        [TestMethod]
        public void div_retornaValor(double a, double b, double esperado)
        {
            /* //Arrange
              double a = 4.0;
              double b = 4.0;
              double esperado = 8;*/

            //Act
            double actual = clsCalculadora.division(a, b);


            //Assert
            Assert.AreEqual(esperado, actual);
        }
    }
}

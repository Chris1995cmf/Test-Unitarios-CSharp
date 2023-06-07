namespace TestPrueba
{
    [TestClass]
    public class Test_Calculadora
    {
        [TestMethod]
        public void Test_Suma_Correcta()
        {
            //Arrange: inicializamos las variables
            int sumando1 = 2;
            int sumando2 = 3;

            //Act: ejecutamos el metodo a testear
            int resultado = CalculadoraEjemplo.Suma(sumando1, sumando2);

            //Assert: comprobación de los valores
            Assert.AreEqual(5, resultado);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))] // cuando hay exceptions no hace falta agregar un ASSERT para que haga el test
        public void test_exception()
        {
            int dividendo = 120;
            int divisor = 0;
            double resultado = CalculadoraEjemplo.Division(dividendo, divisor);
        }
    }
}
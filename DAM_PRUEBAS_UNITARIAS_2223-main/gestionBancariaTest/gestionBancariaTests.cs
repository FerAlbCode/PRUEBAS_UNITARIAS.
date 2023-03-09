using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace gestionBancariaTest
{
    using gestionBancariaApp;

    [TestClass] 

    public class gestionBancariaTests
    {
        //Unit test code[TestMethod]
        [TestMethod]
        public void validarMetodoIngreso()
        {
            //Preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            //Metodo a probar.
            cuenta.realizarIngreso(ingreso);

            //Afirmación de la prueba (valor esperadoVs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            //Resultado esperado.
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }


        [TestMethod]
        public void ValidarMetodoReintegro()
        {
            //Preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            //Metodo a probar.
            cuenta.realizarReintegro(ingreso);

            //Afirmación de la prueba (valor esperadoVs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            //Resultado esperado.
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
    }
}

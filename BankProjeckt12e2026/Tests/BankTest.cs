using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankProjeckt12e2026.Tests
{
    [TestFixture]
    internal class BankTest
    {
        Bank b;

        [SetUp]
        public void Setup()
        {
            b = new Bank();
            b.NewAccount("1234");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Minden teszt végén");
        }

         [Test]
        public void InitialBalanceIsZero()
        {

            /*
            //Előkészítő
            var b = new Bank();

            //Tesztelés
            b.NewAccount("1234");
            */

            //Eredmény
            Assert.That(b.GetBalance("1234"), Is.Zero);

        }

        [Test]
        public void Deposit()
        {
            
            b.Deposit("1234", 50000);

            Assert.That(b.GetBalance("1234"), Is.EqualTo(50000));

        }

        [Test]
        public void MultipleDeposits()
        {
            
            b.Deposit("1234", 50000);
            b.Deposit("1234", 50000);
            Assert.That(b.GetBalance("1234"), Is.EqualTo(100000));
        }


        [Test]
        public void NegativeDeposit()
        {
            
            Assert.Throws<ArgumentException>(
                () =>
                {
                    b.Deposit("1234", -10000);

                }
            );

        }
    }
}

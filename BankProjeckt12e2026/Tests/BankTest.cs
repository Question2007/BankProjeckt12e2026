using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankProjeckt12e2026.Tests
{
    [TestFixture]
    internal class BankTest
    {
        [Test]
        public void InitialBalanceIsZero()
        {
            //Előkészítő
            var b = new Bank();

            //Tesztelés
            b.NewAccount("1234");

            //Eredmény
            Assert.That(b.GetBalance("1234"), Is.Zero);

        }

        [Test]
        public void Deposit()
        {
            var b = new Bank();

            b.NewAccount("1234");
            b.Deposit("1234", 50000);

            Assert.That(b.GetBalance("1234"), Is.EqualTo(50000));

        }

        [Test]
        public void MultipleDeposits()
        {
            var b = new Bank();
            b.NewAccount("1234");
            b.Deposit("1234", 50000);
            b.Deposit("1234", 50000);
            Assert.That(b.GetBalance("1234"), Is.EqualTo(100000));
        }
    }
}

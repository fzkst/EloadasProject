using EloadasProject;
using NUnit.Framework;
using System;

namespace TestEloadasProject
{
    public class Tests
    {
        Eloadas eloadas; 

        [SetUp]
        public void Setup()
        {
            eloadas = new Eloadas(5, 5);
        }

        [Test]
        public void UjEloadasNullaParameterrel()
        {
            Assert.Throws<ArgumentException>(() => new Eloadas(0, 5));
        }

        [Test]
        public void FoglalasLetrejon()
        {
            Assert.True(eloadas.Lefoglal());
        }

        [Test]
        public void MindenHelyFoglaltFoglalasNemJottLetre()
        {
            eloadas.MindenHelyFoglaltSeged();
            Assert.False(eloadas.Lefoglal());
        }

        [Test]
        public void NincsenekSzabadHelyek()
        {
            eloadas.MindenHelyFoglaltSeged();
            Assert.AreEqual(0, eloadas.getSzabadHelyek);            
        }

        [Test]
        public void MindenHelySzabad()
        {            
            Assert.AreEqual(25, eloadas.getSzabadHelyek);
        }

        [Test]
        public void HuszonkettoHelySzabad()
        {           
            eloadas.Lefoglal();
            eloadas.Lefoglal();
            eloadas.Lefoglal();
            Assert.AreEqual(22, eloadas.getSzabadHelyek);
        }

        [Test]
        public void TelthazasEloadas()
        {
            eloadas.MindenHelyFoglaltSeged();
            Assert.True(eloadas.getTeli);
        }

        [Test]
        public void NincsTelthaz()
        {
            Assert.False(eloadas.getTeli);
        }

        [Test]
        public void ElsoHelyFoglalt()
        {
            eloadas.Lefoglal();
            Assert.True(eloadas.Foglalt(1, 1));
        }

        [Test]
        public void MasodikHelySzabad()
        {
            eloadas.Lefoglal();
            Assert.False(eloadas.Foglalt(1, 2));
        }

        [Test]
        public void FoglaltLekerdezesHibasParameterrel()
        {
            Assert.Throws<ArgumentException>(() => eloadas.Foglalt(0, 6));
        }



    }
}
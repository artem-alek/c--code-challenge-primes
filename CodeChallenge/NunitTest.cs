using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

// Installed NUnit from the site. Added the NUnit.dll into preferences of the project
// and installed a extension to use it inside visual studio.

namespace CodeChallenge
{
    [TestFixture]

    public class NunitTest
    {
        [Test]

        
        // A sample test that is working.
        public void testingSample()
        {
            int a = 100;
            int b = 100;
            Assert.AreEqual(a, b);
        }

   // At the bootcamp we covered TDD but had very little practice due to time. We never wrote our own test, 
   // We just had homework assignements where we fixed tests given to use. I am at a loss where to start writing my test.
   // I understand the logic but have no clue were to begin.

        public void filePathTest()
        {
            // I would like to test to see if a filePath is a string inputed from user.
        }

        public void counterTest()
        {
            // I would like to make sure that the counter is working properly.
        }

        public void testList()
        {
            // I would like to make sure the list is growing and that the .Add() working.
            // I would check the list.length and compare it from before.
        }

        public void testPrimeLogic()
        {
            // Here I would test the prime logic and see if the remainder is working correctly.
            // Also would like to make sure that if a string comes into the logic that it catches it.
        }
    }
}

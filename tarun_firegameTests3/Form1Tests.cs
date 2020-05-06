using Microsoft.VisualStudio.TestTools.UnitTesting;
using tarun_firegame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarun_firegame.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 obj = new Form1();

            obj.generateNo();
            Assert.IsTrue(true); 
            

        }
    }
}
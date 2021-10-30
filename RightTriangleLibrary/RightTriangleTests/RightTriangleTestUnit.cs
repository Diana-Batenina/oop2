using Microsoft.VisualStudio.TestTools.UnitTesting;
using RightTriangleLibrary;
using System;
using System.IO;

namespace RightTriangleTests
{
    [TestClass]
     
        public class RightTriangleTestUnit
        {
            [TestMethod]
            public void ConstructorTestMethod()
            {
                var myTriangle = CreateTestTriangle();

                double myHypotenuse = 5.0;

                Assert.AreEqual(3.0, myTriangle.SideA);
                Assert.AreEqual(4.0, myTriangle.SideB);
                Assert.AreEqual(5.0, myTriangle.Hypotenuse);
            }

            [TestMethod]
            public void ToStringTestMethod()
            {
                Assert.AreEqual("Сторона А=3, Сторона В=4", CreateTestTriangle().ToString());
            }

            [TestMethod]
            public void DisplayTestMethod()
            {
                var t1 = CreateTestTriangle();
                var t2 = new RightTriangle(6,8);

                var consoleOut = new[]
                {
                        "Прямоугольный треугольник со сторонами 3см и 4см",
                        "Прямоугольный треугольник со сторонами 6см и 8см",
                };

                TextWriter oldOut = Console.Out;

                StringWriter output = new StringWriter();
                Console.SetOut(output);

                t1.Display();
                t2.Display();

                Console.SetOut(oldOut);

                var outputArray = output.ToString().Split(new[] { "\r\n" },
                    StringSplitOptions.RemoveEmptyEntries);

                Assert.AreEqual(2, outputArray.Length);
                for (var i = 0; i < consoleOut.Length; i++)
                    Assert.AreEqual(consoleOut[i], outputArray[i]);
            }

            [TestMethod]
            public void EqualsTestMethod()
            {
                RightTriangle t1 = new RightTriangle(12, 5);
                RightTriangle t2 = new RightTriangle(12, 5);

                RightTriangle t3 = new RightTriangle(15,8);

                Assert.AreEqual(true, t1.Equals(t2));
                Assert.AreEqual(false, t1.Equals(t3));
            }

            [TestMethod]
            public void MultTestMethod()
            {
                RightTriangle t1 = new RightTriangle(8,15);

                int x = 5;

                RightTriangle t2 = x * t1;

                Assert.AreEqual("Сторона А=40, Сторона В=75", t2.ToString());

            }
            private RightTriangle CreateTestTriangle()
            {
                return new RightTriangle(3,4);
            }
        }

}




        

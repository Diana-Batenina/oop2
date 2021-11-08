using System;

namespace RightTriangleLibrary
{
    
        public struct RightTriangle
        {
            public double SideA;
            public double SideB;
            public readonly double Hypotenuse;

            public RightTriangle(double sideA, double sideB)
            {
                
                if (sideA <= 0 || sideB <= 0)
                {
                    throw new Exception("Вводимые значения должны быть положительными.");
                }

                SideA = sideA;
                SideB = sideB;
                Hypotenuse = Math.Round(Math.Sqrt(sideA * sideA + sideB * sideB),4);
            }
            public static RightTriangle Read()
            {
                double sideA;
                double sideB;

                while (true)
                {
                    Console.WriteLine("Введите сторону А:");
                    sideA = Math.Round(double.Parse(Console.ReadLine()),4);

                    Console.WriteLine("Введите сторону В:");
                    sideB = Math.Round(double.Parse(Console.ReadLine()),4);



                    if (sideA <= 0 || sideB <= 0)
                    {
                        throw new Exception("Вводимые значения должны быть положительными.");
                    }
                    else break;
                }

                return new RightTriangle(sideA, sideB);
            }

            public override string ToString()
            {
                return $"Сторона А={SideA}, Сторона В={SideB}";
            }

            public override bool Equals(object obj1)
            {
                if (obj1 is RightTriangle)
                {
                    RightTriangle rt = (RightTriangle)obj1;

                    return (SideA == rt.SideA && SideB==rt.SideB);
                }
                else
                {
                    return false;
                }

            }

            public override int GetHashCode()
            {
                return Hypotenuse.GetHashCode();
            }
            public void Display()
            {
                Console.WriteLine($"Прямоугольный треугольник со сторонами {SideA}см и {SideB}см");
            }
            
            public static RightTriangle operator *(double x, RightTriangle rt)
            {
                if (x <= 0)
                {
                    throw new Exception("Х должен быть положительным");
                }
                else
                {
                    RightTriangle rt2 = new RightTriangle(rt.SideA*x, rt.SideB*x);
                    return rt2;
                }
            }

        }
}

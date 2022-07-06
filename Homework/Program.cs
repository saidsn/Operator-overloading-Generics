using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit
            //Celsius celsius = new Celsius(100);
            //Kelvin kelvin = celsius;
            //kelvin.Degree = celsius.Degree + 273;
            //Console.WriteLine(kelvin.Degree);

            //Kelvin kelvin = new Kelvin(273);
            //Celsius celsius = kelvin;
            //celsius.Degree = kelvin.Degree - 273;
            //Console.WriteLine(celsius.Degree);
            #endregion

            #region Explicit
            //Celsius celsius = new Celsius(100);
            //Kelvin kelvin = (Celsius)celsius;
            //Console.WriteLine(kelvin.Degree);

            //Kelvin kelvin = new Kelvin(273);
            //Celsius celsius = (Kelvin)kelvin;
            //Console.WriteLine(celsius.Degree);
            #endregion



        }
    }
    #region Kelvin
    //public class Kelvin
    //{
    //    public double Degree { get; set; }
    //    public Kelvin(double degree)
    //    {
    //        Degree = degree;
    //    }

    //    public static implicit operator Celsius(Kelvin kelvin)
    //    {
    //        return new Celsius(kelvin.Degree - 273);
    //    }

    //    public static explicit operator Kelvin(Celsius celsius)
    //    {
    //        return new Kelvin(celsius.Degree - 273);
    //    }

    //}
    #endregion

    #region Celsius
    //public class Celsius
    //{
    //    public double Degree { get; set; }
    //    public Celsius(double degree)
    //    {
    //        Degree = degree;
    //    }

    //    public static implicit operator Kelvin(Celsius celsius)
    //    {
    //        return new Kelvin(celsius.Degree + 273);
    //    }
    //    public static explicit operator Celsius(Kelvin kelvin)
    //    {
    //        return new Kelvin(kelvin.Degree + 273);
    //    }
    //}
    #endregion

}

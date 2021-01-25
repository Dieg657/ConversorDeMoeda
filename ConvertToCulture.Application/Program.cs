using System;
using ConvertToCulture.Domain;

namespace ConvertToCulture.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 2)
                {
                    CultureInformation.IsNumber(args[0]);
                    System.Console.WriteLine("{0} {1}",
                    CultureConvert.ValueToCulture(args[0], CultureInformation.SetCulture(args[1]))
                    , args[1]);
                }
                else
                {
                    throw new Exception("Insira o valor e a linguagem para conversão ex: 12.00 en_US");
                }
            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }
}

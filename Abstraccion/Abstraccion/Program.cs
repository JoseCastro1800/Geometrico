using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos  la clase triangulo y la llamamos con su metodo
            Triangulo triangulo = new Triangulo();
            triangulo.Saludar();

            //Instanciamos  la clase cuadrado y la llamamos con su metodo
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Saludar();

            Area area = new Area();
            area.Saludar();

            Console.ReadKey();
        }
    }
}

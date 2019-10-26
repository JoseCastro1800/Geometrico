using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{ 
    public class Area : Geometricos
    {
        
        public override string Nombre { get ; set ; }
        public override int Base { get; set; }
        public override int Altura { get ; set ; }

        public override void Saludar()
        {
            Area area = new Area();
            Console.WriteLine("Area para un triangulo");

           
           
            
           




        }
    }
}

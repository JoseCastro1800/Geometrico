using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public abstract class Geometricos
    {
        //Aqui solamente se llegan a delcarar los metodos
        public abstract void Saludar();
        //Si llegase a tener parametros se los incluremos en el parentesis
        public abstract string Nombre { get; set; }
        public abstract int Base { get; set; }

        public abstract int Altura { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteInjDependencias
{
    public class TesteA : ITesteA
    {
        public Guid IdReferencia { get; }

        public TesteA()
        {
            this.IdReferencia = Guid.NewGuid();
        }
    }

    public class TesteB : ITesteB
    {
        public Guid IdReferencia { get; }

        public TesteB()
        {
            this.IdReferencia = Guid.NewGuid();
        }
    }

    public class TesteC
    {
        public Guid IdReferencia { get; }

        public TesteC()
        {
            this.IdReferencia = Guid.NewGuid();
        }
    }
}
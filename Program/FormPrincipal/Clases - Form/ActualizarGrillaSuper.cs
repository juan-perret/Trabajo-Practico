using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal
{
    internal interface ActualizarGrillaSuper
    {
        void ActualizarGrilla(decimal costo, bool max);
        void ActualizarGrilla(int puntoPedido, bool max);
    }
}

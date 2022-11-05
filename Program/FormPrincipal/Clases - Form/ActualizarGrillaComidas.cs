using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal
{
    internal interface ActualizarGrillaComidas
    {
        void CargarGrilla();
        void ActualizarGrilla(int idReceta);
        void ActualizarGrilla(DateTime fecha1, DateTime fecha2);
    }
}

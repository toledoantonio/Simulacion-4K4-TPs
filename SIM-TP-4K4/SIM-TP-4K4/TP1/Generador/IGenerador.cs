using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.Generador
{
    public interface IGenerador
    {
        List<Iteracion> generarPseudoAleatorios(int n);
        Iteracion siguientePseudoAleatorio();
        IntervaloList getVectorIntervalos();
    }
}

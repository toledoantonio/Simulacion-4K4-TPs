using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP3.Distribuciones
{
    public interface Distribucion
    {
        List<double> generarVariables();

        List<int> generarVariablesPoisson();

        double generarVariable(double x, double y, double z);
    }
}

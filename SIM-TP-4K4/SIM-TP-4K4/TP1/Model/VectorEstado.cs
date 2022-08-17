using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP1.Model
{
    public class VectorEstado
    {
        public IntervaloList intervalos { get; set; }

        public int xi { get; set; }
        public int xi_1 { get; set; }
        public double rnd { get; set; }

        public VectorEstado(int xi, int cantidaIntervalos, double amplitud)
        {
            this.intervalos = new IntervaloList(cantidaIntervalos, amplitud);
            this.xi = xi;
        }

        public VectorEstado(int xi, int xi_1 ,int cantidaIntervalos, double amplitud)
        {
            this.intervalos = new IntervaloList(cantidaIntervalos, amplitud);
            this.xi = xi;
            this.xi_1 = xi_1;
        }

        public void actualizar(int orden)
        {
            this.intervalos.actualizarIntervalos(this.rnd, orden, orden - 1);
        }

        public object[] getDatos(int orden, bool fr)
        {
            return construirVector(false, orden, fr);
        }

        public object[] getDatosAditivo(int orden, bool fr) {
            return construirVector(true, orden, fr);
        }


        public object[] construirVector(bool aditivo, int orden, bool fr)
        {
            int campos = (aditivo) ? 4 : 3;
            object[] data = new object[campos + this.intervalos.intervalos.Count];
            data[0] = orden;
            data[1] = this.xi;
            data[2] = (aditivo) ? this.xi_1 : this.rnd;
            data[3] = (aditivo) ? this.rnd : 0;
            string[] frecuencias = (fr) ? this.intervalos.getValoresRelativa() : this.intervalos.getValoresAbsoluta();
            for (int i = 0; i < frecuencias.Length; i++)
            {
                data[i + campos] = frecuencias[i];
            }
            return data;
        }
        
        public object[] getDatosC(int orden, bool fr)
        {
            object[] data = new object[2 + this.intervalos.intervalos.Count];
            data[0] = orden;
            data[1] = this.rnd;
            string[] frecuencias = (fr) ? this.intervalos.getValoresRelativa() : this.intervalos.getValoresAbsoluta();
            for (int i = 0; i < frecuencias.Length; i++)
            {
                data[i + 2] = frecuencias[i];
            }
            return data;
        }
    }
}

using SIM_TP_4K4.TP1.Generador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP3
{
    public class Controlador
    {
        public List<object[]> listaRnd { get; set; }

        public Controlador()
        {

        }


        public List<object[]> generarRnd(int tamañoMuestra)
        {
            Propio generador = new Propio(tamañoMuestra);
            this.listaRnd = generador.generarPseudoAleatorios(tamañoMuestra);
            return this.listaRnd;
        }
    }
}

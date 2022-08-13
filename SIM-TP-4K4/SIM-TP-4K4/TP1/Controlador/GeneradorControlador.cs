using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.Generador
{
    public class GeneradorControlador
    {
        public int semilla { get; set; }
        public int semillaAnterior { get; set; }
        public int cteC { get; set; }
        public int cteMultiplicadora { get; set; }
        public int moduloM { get; set; }
        public int metodo { get; set; }
        public int tamMuestra { get; set; }

        public int cantidadIntervalos {get; set; }

        public IGenerador generador { get; set; }
        public bool frecuenciaRel { get; set; }


        public GeneradorControlador(int semilla, int cteIndependiente, int cteMultiplicadora, int moduloM, int tamMuestra, int cantidadIntervalos,int metodo, bool frecuenciaRel, int semillaAnterior) {
            this.semilla = semilla;
            this.cteC = cteIndependiente;
            this.cteMultiplicadora = cteMultiplicadora;
            this.moduloM = moduloM;
            this.tamMuestra = tamMuestra;
            this.cantidadIntervalos = cantidadIntervalos;
            this.frecuenciaRel = frecuenciaRel;
            this.semillaAnterior = semillaAnterior;
            setGenerador(metodo);
        }

        public void setGenerador(int metodo)
        {
            switch (metodo)
            {
                case 1:
                    this.generador = new CongruencialMixto(cteMultiplicadora, cteC, semilla, moduloM, cantidadIntervalos, frecuenciaRel);
                    break;
                case 2:
                     this.generador = new CongruencialMultiplicativo(cteMultiplicadora, semilla, moduloM, cantidadIntervalos, frecuenciaRel);
                    break;
                case 3:
                    this.generador = new Aditivo(semilla, semillaAnterior, moduloM, frecuenciaRel, cantidadIntervalos);
                    break;
                default:
                    this.generador = null;
                    break;
            }
        }

        public List<Iteracion> getRandoms()
        {
            return this.generador.generarPseudoAleatorios(this.tamMuestra);
        }

        public IntervaloList getListaIntervalos()
        {
            return this.generador.getVectorIntervalos();
        }

        public List<Iteracion> getRandoms(int cantidad)
        {
            this.tamMuestra += cantidad;
            return this.generador.generarPseudoAleatorios(cantidad);
        }

        public Iteracion getSiguiente()
        {
            ++this.tamMuestra;
            return this.generador.siguientePseudoAleatorio();
        }
    }
}

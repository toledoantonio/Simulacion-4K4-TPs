using SIM_TP_4K4.Model;
using SIM_TP_4K4.TP1.Generador;
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
        public int k { get; set; }
        public int g { get; set; }
        public IGenerador generador { get; set; }
        public bool frecuenciaRel { get; set; }
        public int ultimaSim { get; set; }

        public GeneradorControlador(int semilla, int cteIndependiente, int cteMultiplicadora, int moduloM, int tamMuestra, int cantidadIntervalos,int metodo, bool frecuenciaRel, int semillaAnterior, int k, int g) {
            this.semilla = semilla;
            this.cteC = cteIndependiente;
            this.cteMultiplicadora = cteMultiplicadora;
            this.moduloM = moduloM;
            this.tamMuestra = tamMuestra;
            this.cantidadIntervalos = cantidadIntervalos;
            this.frecuenciaRel = frecuenciaRel;
            this.semillaAnterior = semillaAnterior;
            this.g = g;
            this.k = k;
            setGenerador(metodo);
        }

        public void setGenerador(int metodo)
        {
            switch (metodo)
            {
                case 1:
                    this.generador = new CongruencialMixto(cteMultiplicadora, cteC, semilla, moduloM, cantidadIntervalos, frecuenciaRel, k , g);
                    break;
                case 2:
                     this.generador = new CongruencialMultiplicativo(cteMultiplicadora, semilla, moduloM, cantidadIntervalos, frecuenciaRel, k, g);
                    break;
                case 3:
                    this.generador = new Aditivo(semilla, semillaAnterior, moduloM, frecuenciaRel, cantidadIntervalos);
                    break;
                case 4:
                    this.generador = new Propio(tamMuestra, cantidadIntervalos, frecuenciaRel);
                    break;
                default:
                    this.generador = null;
                    break;
            }
        }

        public List<object[]> getRandoms()
        {
            int cant = (tamMuestra < 20) ? tamMuestra: 20;
            ultimaSim = cant;
            return this.generador.generarPseudoAleatorios(cant);
        }

        public IntervaloList getListaIntervalos()
        {
            return this.generador.getVectorIntervalos();
        }

        public List<object[]> getRandoms(int cantidad)
        {
            this.ultimaSim += cantidad;
            return this.generador.generarPseudoAleatorios(cantidad);
        }

        public List<object[]> ultimosDos(int cantidad)
        {
            this.ultimaSim += cantidad;

            List<object[]> result = new List<object[]>();
            for (int i = 0; i < cantidad; ++i)
            {
                if (i == (cantidad - 1) || i == (cantidad - 2))
                {
                    result.Add(this.generador.siguientePseudoAleatorio());

                } else
                {
                    this.generador.siguientePseudoAleatorio();

                }

            }
            return result;
        }

        public List<object[]> hastaN()
        {
            List<object[]> result = new List<object[]>();

            if(tamMuestra - ultimaSim > 0)
            {
                for(int i = ultimaSim; i < tamMuestra; ++i)
                {
                    if (i == (tamMuestra - 1) || i == (tamMuestra - 2))
                    {
                        result.Add(this.generador.siguientePseudoAleatorio());
              
                    } else
                    {
                        this.generador.siguientePseudoAleatorio();

                    }

                }
            }
            ultimaSim = tamMuestra;
            return result;
        }

        public object[] getSiguiente()
        {
            ++ultimaSim;
            return this.generador.siguientePseudoAleatorio();
        }

        public List<Object[]> getDatosChiCuadrado()
        {
            List<Object[]> datos = new List<Object[]>();

            IntervaloList estadoIntervalos = this.generador.getVectorIntervalos();
            double frecuenciaEsperada = this.tamMuestra / (double) this.cantidadIntervalos;

            estadoIntervalos.setFrecuenciaEsperada(frecuenciaEsperada);

            double anterior = 0;
            foreach(Intervalo it in estadoIntervalos.intervalos) {
                Object[] datosFila = new Object[8];
                datosFila[0] = it.limInf;
                datosFila[1] = it.limSup;
                datosFila[2] = it.frecuenciaAbsoluta;
                datosFila[3] = estadoIntervalos.frecuenciaEsperada;
                double[] valores = calcularValoresChiFila(frecuenciaEsperada, it.frecuenciaAbsoluta, anterior);
                anterior = valores[3];

                datosFila[4] = valores[0];
                datosFila[5] = valores[1];
                datosFila[6] = valores[2];
                datosFila[7] = valores[3];
                datos.Add(datosFila);
            }

            return datos;
        }

        public double[] calcularValoresChiFila(double fe, double fo, double anterior) {
            double resta = fe - fo;
            double potencia = Math.Pow(resta, 2);
            double estadistico = Util.truncar(potencia / fe);

            double acumulado = estadistico + anterior;

            double[] valores = new double[4] {resta, potencia, estadistico, acumulado };
            return valores;
        }

        public bool superaMuestra(int cantidad)
        {
            return tamMuestra - (cantidad + ultimaSim) < 0;
        }
    }
}

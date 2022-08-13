﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.Generador
{
    public class GeneradorControlador
    {
        public int semilla { get; set; }
        public int cteC { get; set; }
        public int cteMultiplicadora { get; set; }
        public int moduloM { get; set; }
        public int metodo { get; set; }
        public long tamMuestra { get; set; }

        public int cantidadIntervalos {get; set; }

        public IGenerador generador { get; set; }

        public GeneradorControlador(int metodo) : this(37, 7, 19, 53, 20, 10, metodo) {}
        
        public GeneradorControlador(int semilla, int cteIndependiente, int cteMultiplicadora, int moduloM, long tamMuestra, int cantidadIntervalos,int metodo) {
            this.semilla = semilla;
            this.cteC = cteIndependiente;
            this.cteMultiplicadora = cteMultiplicadora;
            this.moduloM = moduloM;
            this.tamMuestra = tamMuestra;
            this.cantidadIntervalos = cantidadIntervalos;
            setGenerador(metodo);
        }

        public void setGenerador(int metodo)
        {
            switch (metodo)
            {
                case 1:
                   // this.generador = new CongruencialMixto();
                    break;
                case 2:
                   // this.generador = new CongruencialMultiplicativo();
                    break;
                case 3:
                   // this.generador = new Aditivo();
                    break;
                default:
                    this.generador = null;
                    break;
            }
        }
    }
}
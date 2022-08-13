﻿using SIM_TP_4K4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP1.Model
{
    public class IntervaloList
    {
        public List<Intervalo> intervalos { get; set; }

        public IntervaloList(int cantidadIntervalos, double amplitud)
        {
            intervalos = new List<Intervalo>();
            construirIntervalos(cantidadIntervalos, amplitud);
        }

        public void construirIntervalos(int cantidadIntervalos, double amplitud)
        {
           double limInf = 0.0000;
           double limSup = limInf + amplitud;
           for (int i = 0; i < cantidadIntervalos; i++) {     
                Intervalo intervalo = new Intervalo(limInf, limSup);
                limInf = limSup;
                limSup = limInf + amplitud;
                intervalos.Add(intervalo);
            }
        }

        public void actualizarIntervalos(double random, int orden, int ordenAnterior)
        {
           foreach(Intervalo i in intervalos)
            {
                if(i.contieneRnd(random)) 
                {
                    i.contar(orden, ordenAnterior, 1); 
                } else
                {
                    i.contar(orden, ordenAnterior, 0);
                }
            }
        }

        public int[] getValores()
        {
            int[] valores = intervalos.Select(intervalo => intervalo.frecuencia).ToArray();
            return valores;
        }
    }
}

﻿using SIM_TP_4K4.TP3.Distribuciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP_4K4.TP4
{
    public class VectorEstado
    {

        public VectorEstado(Dictionary<int, Distribucion> distribuciones, double[]infoT1, double[]infoT2, double[]infoT3, double[]infoT4, double[]infoT5)
        {
            this.vectorDatos = new double[18];
            this.distribuciones = distribuciones;
            this.iniciarVector();
            this.infoT1 = infoT1;
            this.infoT2 = infoT2;
            this.infoT3 = infoT3;
            this.infoT4 = infoT4;
            this.infoT5 = infoT5;

        }

        public void iniciarVector()
        {
            this.numEnsamble = 0;
            this.Rnd1 = 0;
            this.Rnd2 = 0;
            this.Rnd3 = 0;
            this.Rnd4 = 0;
            this.Rnd5 = 0;
            this.t1 = 0;
            this.t2 = 0;
            this.t3 = 0;
            this.t4 = 0;
            this.t5 = 0;
            this.finT4 = 0;
            this.initT5 = 0;
            this.finT5 = 0;
            this.duracionTotal = 0;
            this.duracionTotalAcumulada = 0;
            this.duracionTotalPromedio = 0;
            this.prob45 = 0;
        }

        public void siguienteSimulacion(double rnd1, double rnd2, double rnd3, double rnd4, double rnd5) {
            this.numEnsamble ++;
            this.Rnd1 = rnd1;
            this.Rnd2 = rnd2;
            this.Rnd3 = rnd3;
            this.Rnd4 = rnd4;
            this.Rnd5 = rnd5;
            this.t1 = calcularDuracionT1();
            this.t2 = calcularDuracionT2();
            this.t3 = calcularDuracionT3();
            this.t4 = calcularDuracionT4();
            this.t5 = calcularDuracionT5();
            this.finT4 = finalizacionT4();
            this.initT5 = iniciaT5();
            this.finT5 = finalizacionT5();
            this.duracionTotal = calcularDuracionTotal();
            this.duracionTotalAcumulada = calcularAcumulada();
            this.duracionTotalPromedio = calcularDuracionTotalPromedio();
            this.prob45 = calcularProbabilidad();
            this.actualizarVectores();
        }


        private double calcularDuracionT1() {
            return this.distribuciones[1].generarVariable(this.infoT1[0], this.infoT1[1], this.Rnd1);
        }
        private double calcularDuracionT2() {
           return this.distribuciones[1].generarVariable(this.infoT2[0], this.infoT2[1], this.Rnd2);

        }
        private double calcularDuracionT3() {
            return this.distribuciones[0].generarVariable(this.infoT3[0], 0, this.Rnd3);

        }
        private double calcularDuracionT4() {
            return this.distribuciones[1].generarVariable(this.infoT4[0], this.infoT4[1], this.Rnd4);

        }
        private double calcularDuracionT5() {
            return this.distribuciones[0].generarVariable(this.infoT5[0], 0, this.Rnd5);
        }


        private double finalizacionT4()
        {
            return this.t1 + this.t4;
        }

        private double iniciaT5()
        {
            return (this.t2 > this.finT4) ? t2 : finT4;
        }

        private double finalizacionT5()
        {
            return this.initT5 + this.t5;
        }

        private double calcularDuracionTotal()
        {
            return (this.t3 > this.finT5) ? t3 : finT5;
        }

        private double calcularAcumulada()
        {
            
            return this.duracionTotalAcumulada + this.duracionTotal;
        }

        private double calcularDuracionTotalPromedio()
        {
            return this.duracionTotalAcumulada / this.numEnsamble;
        }

        private double calcularProbabilidad()
        {
            double es45 = (duracionTotal <= 45) ? 1 : 0;
            double anterior = prob45 * (numEnsamble - 1);
            double suma = es45 + anterior;
            double prob = suma / numEnsamble;

            return prob;
        }

        private void actualizarVectores()
        {
            this.vectorDatos = new double[] { this.numEnsamble, this.Rnd1, this.t1, this.Rnd2, this.t2, this.Rnd3, this.t3, this.Rnd4, this.t4, this.Rnd5, this.t5, this.finT4, this.initT5, this.finT5, this.duracionTotal, this.duracionTotalAcumulada, this.duracionTotalPromedio, this.prob45};
          
        }


        public object[] getActualVectorAsObject()
        {
            return this.vectorDatos.Select((x) => (object)x).ToArray();
        }

        public double[] vectorDatos { get; set; }

        public int numEnsamble { get; set; }

        public double Rnd1 { get; set; }

        public double t1 { get; set; }

        public double Rnd2 { get; set; }

        public double t2 { get; set; }

        public double Rnd3 { get; set; }

        public double t3 { get; set; }

        public double Rnd4 { get; set; }

        public double t4 { get; set; }

        public double Rnd5 { get; set; }

        public double t5 { get; set; }

        public double finT4 { get; set; }

        public double initT5 { get; set; }

        public double finT5 { get; set; }

        public double duracionTotal { get; set; }

        public double duracionTotalAcumulada { get; set; }

        public double duracionTotalPromedio { get; set; }

        public double prob45 { get; set; }



        public Dictionary<int, Distribucion> distribuciones { get; set; }

        public double[] infoT1 { get; set; }
        public double[] infoT2 { get; set; }
        public double[] infoT3 { get; set; }
        public double[] infoT4 { get; set; }
        public double[] infoT5 { get; set; }

    }
}
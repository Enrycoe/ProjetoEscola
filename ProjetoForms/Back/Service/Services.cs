﻿using ProjetoForms.Back.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms.Back.Service
{
    public static class Services
    {
        public static double CalcularMediaPorBimestre(int qtdNotas, double somaNotas)
        {
            return qtdNotas / somaNotas;
        }

        internal static string AprovadoOuReporovado(double mediaFinal, double media1, double media2, double media3, double media4)
        {
            Media media = new Media();
            if (media1 == -1 || media2 == -1 || media3 == -1 || media4 == -1)
            {
                return "";
            }
            if (mediaFinal > media.NotaMinima)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";
            }
        }

        internal static double CalcularMediaFinal(double media1, double media2, double media3, double media4)
        {
            return (media1 + media2 + media3 + media4) / 4;
        }

        internal static string MostrarMediaFinal(double mediaFinal, double media1, double media2, double media3, double media4)
        {
            if (media1 == -1 || media2 == -1 || media3 == -1 || media4 == -1)
            {
                return "--,--";
            }
            return mediaFinal.ToString("F");
        }

        internal static string MostrarNotaOuNula(double media)
        {
            if (media == -1)
            {
                return "--,--";
            }
            else
            {
                return media.ToString("F");
            }
        }

        internal static bool VerificarSeNotaEValida(double nota)
        {
            Prova prova = new Prova();

            if (nota > prova.NotaMaxima || nota < prova.NotaMinima)
            {
                return false;
            }
            return true;
        }
    }
}

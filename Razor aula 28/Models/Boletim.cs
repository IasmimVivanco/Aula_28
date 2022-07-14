﻿using System.Globalization;
namespace Razor_aula_28.Models
{
    public class Boletim
    {
        public string Materia { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public string Status { get; set; }
        public CultureInfo Culture { get; set; }
    }
}

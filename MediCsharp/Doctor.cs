﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MediCsharp
{
    public enum DiaSemana {Lunes, Martes, Miercoles, Jueves,  Viernes, Sabado, Domingo }
    public class Doctor: Persona
    {
        public int CodDoctor { get; set; }
        public string NombreDoctor { get; set; }
        public String ApellidoDoctor { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
        public DiaSemana GuardiaMedico { get; set; }
        

        
       

        

              

        public void ActualizarDatosDoctor()
        { }


    }
}

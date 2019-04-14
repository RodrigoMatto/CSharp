using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public class Paciente: Persona
    {
        public int CodPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }

        public string sexo { get; set; }
        public string ciudad { get; set; }
        public string estadocivil { get; set; }



        public Paciente()
        { }

        public Paciente(int CodPaciente, string NombrePersona, string ApellidoPersona)
        {
            this.CodPaciente = CodPaciente;
            this.NombrePaciente = NombrePaciente;
            this.ApellidoPaciente = ApellidoPaciente;

        }


        public void ActualizarDatosPaciente()
        { }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCsharp
{
    public struct Horario
    { public int Hora { get; set; }
      public int Minuto { get; set; }
    }

   public class Sucursal
    {
        public int CodigoSucursal { get; set; }
        public String NombreSucursal { get; set; }
        public string Direccion { get; set; }
        public Boolean HabilitacionSucursal { get; set; }

        public Horario HorarioApertura { get; set; }
        public Horario HorarioCierre { get; set; }

        public Sucursal()
        { }


        public void ActualizarDatosSucursal()
        { }



    }
}

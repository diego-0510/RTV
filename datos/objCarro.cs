using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class objCarro
    {

        public int placa { get; set; }
        public string marca { get; set; }
        public string anoFabricacion { get; set; }
        public string nombreDueno { get; set; }
        public int ccMotor { get; set; }
        public int vin { get; set; }//numero indenificador de chasis
        public string tipoAlimentacion { get; set; }
        public string colorExterno { get; set; }

        public objCarro(int placa,string marca, string anoFabricacion,string nombreDueno,int ccMotor,int vin,string tipoAlimentacion,string colorExterno)
        {
            this.placa = placa;
            this.marca = marca;
            this.anoFabricacion = anoFabricacion;
            this.nombreDueno = nombreDueno;
            this.ccMotor = ccMotor;
            this.vin = vin;
            this.tipoAlimentacion = tipoAlimentacion;
            this.colorExterno = colorExterno;
        }

        public objCarro()
        {

        }




    }
}

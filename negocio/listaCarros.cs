using datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace negocio
{
    public class listaCarros
    {
        private List<objCarro> listCarros = new List<objCarro>();

        public void crearCarro(int placa, string marca, string anoFabricacion, string nombreDueno, int ccMotor, int vin, string tipoAlimentacion, string colorExterno)
        {
            objCarro carro = new objCarro( placa,marca,anoFabricacion,nombreDueno,ccMotor,vin,tipoAlimentacion,colorExterno);
            listCarros.Add(carro);
        }


        public objCarro buscarCarro(int numPlaca)
        {
            objCarro carroBuscado = new objCarro();

            foreach(objCarro buscandoCarro in listCarros)
            {
                if (buscandoCarro.placa== numPlaca)
                {
                    carroBuscado = buscandoCarro;
                    
                }
            }
            return carroBuscado;

        }



    }
}

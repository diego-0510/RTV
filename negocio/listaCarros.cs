using datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public void leerXML()
        {
            XmlTextReader xmlTextReader = new XmlTextReader("C://Users//Estudiante.COMSSC332//source//repos//RTV3//archivo.xml");
            string ultimaEtiqueta = "";
            string valor = "";
            while (xmlTextReader.Read())
            {
                if (xmlTextReader.NodeType == XmlNodeType.Element)
                {
                    ultimaEtiqueta = xmlTextReader.Name;
                    continue;
                }
                if (xmlTextReader.NodeType == XmlNodeType.Text)
                {
                    valor = xmlTextReader.ReadContentAsString();
                }
            }
        }


        public void guardarXML()
        {
            XmlDocument documento = new XmlDocument();
            XmlElement raiz = documento.CreateElement("listaVehiculos");
            documento.AppendChild(raiz);

            

            foreach(objCarro carroXML in listCarros)
            {
                XmlElement vehiculo = documento.CreateElement("vehiculos");
                raiz.AppendChild(vehiculo);

                XmlElement placa = documento.CreateElement("placa");
                placa.AppendChild(documento.CreateTextNode(carroXML.placa.ToString()));
                vehiculo.AppendChild(placa);

                XmlElement marca = documento.CreateElement("marca");
                marca.AppendChild(documento.CreateTextNode(carroXML.marca));
                vehiculo.AppendChild(marca);

                XmlElement anioFabricacion = documento.CreateElement("anioFabricacion");
                anioFabricacion.AppendChild(documento.CreateTextNode(carroXML.anoFabricacion));
                vehiculo.AppendChild(anioFabricacion);

                XmlElement nombreDueno = documento.CreateElement("nombreDueno");
                nombreDueno.AppendChild(documento.CreateTextNode(carroXML.nombreDueno));
                vehiculo.AppendChild(nombreDueno);

                XmlElement motorCC = documento.CreateElement("motorCC");
                motorCC.AppendChild(documento.CreateTextNode(carroXML.ccMotor.ToString()));
                vehiculo.AppendChild(motorCC);

                XmlElement vin = documento.CreateElement("vin");
                vin.AppendChild(documento.CreateTextNode(carroXML.vin.ToString()));
                vehiculo.AppendChild(vin);

                XmlElement combustion = documento.CreateElement("combustion");
                combustion.AppendChild(documento.CreateTextNode(carroXML.tipoAlimentacion));
                vehiculo.AppendChild(combustion);

                XmlElement color = documento.CreateElement("color");
                color.AppendChild(documento.CreateTextNode(carroXML.colorExterno));
                vehiculo.AppendChild(color);

            }
            documento.Save("C://Users//Estudiante.COMSSC332//source//repos//RTV3//archivo.xml");

            


        }



    }
}

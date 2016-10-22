using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LogicaNegocios;

namespace Logic.Negocios.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IBingoTools
    {
        public int[] GetCrearRandomArray(int cantidadCampos, int minimo, int maximo)
        {
            return CrearArray.CrearRandomArray(cantidadCampos, minimo, maximo);
        }

        public int[] GetDesordenarArray(int[] elArray)
        {
            return ModificarArray.DesordenarArray(elArray);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

       public bool GetestaElNumeroEnArray(int[] elArray, int elNumeroAConsultar) {
            return ConsultarArray.EstaElNumeroEnArray(elArray,elNumeroAConsultar);
        }
        public string GetimprimirArray(int[] elArray)
        {
            return ConsultarArray.ImprimirArray(elArray);
        }

        public Boolean GetsonArraysIguales(int[] array1, int[] array2) {
            return ConsultarArray.SonArraysIguales(array1,array2);
        }

        public CompositeType2 GetDataUsingDataContract(CompositeType2 composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}

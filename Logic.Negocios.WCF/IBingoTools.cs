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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBingoTools
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        int[] GetCrearRandomArray(int cantidadCampos, int minimo, int maximo);

        [OperationContract]
        int[] GetDesordenarArray(int[] elArray);

        [OperationContract]
        bool GetestaElNumeroEnArray(int[] elArray, int elNumeroAConsultar);

        [OperationContract]
        string GetimprimirArray(int[] elArray);

        [OperationContract]
        Boolean GetsonArraysIguales(int[] array1, int[] array2);

        [OperationContract]
        CompositeType2 GetDataUsingDataContract(CompositeType2 composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType2
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

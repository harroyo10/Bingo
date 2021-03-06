﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LogicaNegocios;

namespace Bingo.LogicaNegocios.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILogic
    {
        //Metodos del Juego
        [OperationContract]
        int GetSacarNumeroDeBiombo(Juego j);

        [OperationContract]
        List<CartonBingo> GetObtenerAfortunados(Juego j, int Numero);


        [OperationContract]
        List<string> GetObtenerGanadores(Juego j);

        [OperationContract]
        string GetEncontrarAQueColumnaPertenece(int numero, int intervalo);
    
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
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

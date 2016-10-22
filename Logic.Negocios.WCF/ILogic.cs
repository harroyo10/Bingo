﻿using System;
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
    public interface ILogic
    {
        //Metodos del Juego
        [OperationContract]
        int GetSacarNumeroDeBiombo();

        [OperationContract]
        List<CartonBingo> GetObtenerAfortunados(Juego j, int Numero);


        [OperationContract]
        List<string> GetObtenerGanadores();
/*
        [OperationContract]
        int GetnumerosJugados();

        //Metodos CartonBingo
        [OperationContract]
        string GetJugadorAlQuePertenece(string Nombre);

        //MetodosCampoCarton
        [OperationContract]
        int GetValor(int valor);

        [OperationContract]
        int Getfila(int fila);

        [OperationContract]
        string Getcolumna(string Columna);

        [OperationContract]
        bool GetboolJugado(bool Jugado);

        
        //Metodos HerramientasJuego
        [OperationContract]
        ModalidadJuego GetModalidad(string Modalidad);
        */
        [OperationContract]
        string GetEncontrarAQueColumnaPertenece(int numero, int intervalo);
        /*
        //Metodos Jugador
        [OperationContract]
        string GetNombre(string Nombre);
        [OperationContract]
        int GetCantidadCartones(int Cantidad);
        [OperationContract]
        List<CartonBingo> GetCartones(List<CartonBingo> Cartones);
        
    
    */
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

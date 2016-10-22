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
    public class Service1 : ILogic
    {
    
        //Llaman los Metodos de Juego

        public int GetSacarNumeroDeBiombo() {
            return 1;
            //Juego.SacarNumeroDeBiombo();
        }
        public List<CartonBingo> GetObtenerAfortunados(int Numero) {
            return null;
            //Juego.ObtenerAfortunados(Numero);
        }
        public List<string> GetObtenerGanadores() {
            return null;
            //Juego.ObtenerGanadores();
        }

        public int GetnumerosJugados() {
            return 1;
        }

        //Metodos de CartonBingo
        public string GetJugadorAlQuePertenece(string Nombre) {
            return Nombre;
        }

        //MetodosCampoCarton
        public int GetValor(int valor) {
            return valor;
        }
        public int Getfila(int fila) {
            return fila;
        }
        public string Getcolumna(string Columna) {
            return Columna;
        }
        public bool GetboolJugado(bool Jugado)
        {
            return true;
        }

        //Metodo HerramientaJuego
        public ModalidadJuego GetModalidad(string Modalidad) {
            return HerramientasJuego.GetModalidad(Modalidad);
        }

        public string GetEncontrarAQueColumnaPertenece(int numero, int intervalo) {
            return HerramientasJuego.EncontrarAQueColumnaPertenece(numero, intervalo);
        }

        //Metodos Jugador

        public string GetNombre(string Nombre) {
            return Nombre;
        }

        public int GetCantidadCartones(int Cantidad) {
            return Cantidad;
        }

        public List<CartonBingo> GetCartones(List<CartonBingo> Cartones) {
            return Cartones;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
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

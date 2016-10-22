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
       
        /*
        Jugador Ju = new Jugador();
        CampoCarton CC = new CampoCarton();
    */
        //Llaman los Metodos de Juego

        public int GetSacarNumeroDeBiombo(Juego j) {
            return j.SacarNumeroDeBiombo(); 
        }
        public List<CartonBingo> GetObtenerAfortunados(Juego j, int Numero) {
            return j.ObtenerAfortunados(Numero);
        }
        public List<string> GetObtenerGanadores(Juego j) {
            return j.ObtenerGanadores();
        }
        /*
        public int GetnumerosJugados() {
            // return J.numerosJugados(Numero);
            return 1;
        }

        //Metodos de CartonBingo
        public string GetJugadorAlQuePertenece(string Nombre) {
            return Nombre;
        }

        //MetodosCampoCarton
        public int GetValor(int valor) {
            return CC.valor;
        }
        public int Getfila(int fila) {
            return CC.fila;
        }
        public string Getcolumna(string Columna) {
            return CC.columna;
        }
        public bool GetboolJugado(bool Jugado)
        {
            return CC.boolJugado;
        }
        
        //Metodo HerramientaJuego
        public ModalidadJuego GetModalidad(string Modalidad) {
            return HerramientasJuego.GetModalidad(Modalidad);
        }
        */
        public string GetEncontrarAQueColumnaPertenece(int numero, int intervalo) {
            return HerramientasJuego.EncontrarAQueColumnaPertenece(numero, intervalo);
        }
        
        //Metodos Jugador
        /*
        public string GetNombre(string Nombre) {
            return Ju.nombre;
        }

        public int GetCantidadCartones(int Cantidad) {
            return Ju.cantidadCartones;
        }

        public List<CartonBingo> GetCartones(List<CartonBingo> Cartones) {
            return Ju.cartones;
        }
        */
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

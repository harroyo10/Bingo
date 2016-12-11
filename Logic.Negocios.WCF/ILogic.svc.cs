using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LogicaNegocios;


namespace Bingo.LogicaNegocios.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ILogic
    {
       
        public int GetSacarNumeroDeBiombo(Juego j) {
            return j.SacarNumeroDeBiombo(); 
        }
        public List<CartonBingo> GetObtenerAfortunados(Juego j, int Numero) {
            return j.ObtenerAfortunados(Numero);
        }
        public List<string> GetObtenerGanadores(Juego j) {
            return j.ObtenerGanadores();
        }
        
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

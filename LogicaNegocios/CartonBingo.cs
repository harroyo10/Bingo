using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herramientas;

namespace LogicaNegocios
{
    public class CartonBingo
    {
        Dictionary<string, CampoCarton[]> carton;
        int intervalo;
        ModalidadJuego modalidad;
        List<int> numerosRequeridosParaGanar;
        string jugadorAlQuePertenece;

        public CartonBingo (int intervalo, string modalidad)
        {
            this.intervalo = intervalo;
            this.carton = GenerarCartonBingo();
            this.modalidad = HerramientasJuego.GetModalidad(modalidad);
            this.numerosRequeridosParaGanar = EncontrarNumerosRequeridosParaGanar();
            vaciarPosicionCentral();
            
        }

        public CartonBingo(int intervalo, string modalidad, string jugadorAlQuePertenece)
        {
            this.intervalo = intervalo;
            this.carton = GenerarCartonBingo();
            this.modalidad = HerramientasJuego.GetModalidad(modalidad);
            this.jugadorAlQuePertenece = jugadorAlQuePertenece;
            this.numerosRequeridosParaGanar = EncontrarNumerosRequeridosParaGanar();
            vaciarPosicionCentral();

        }

        public Dictionary<string, CampoCarton[]> getCarton()
        {
            return this.carton;
        }

        private void vaciarPosicionCentral()
        {
            this.carton["N"][2].valor = 0;
        }

        public string ImprimirColumna(CampoCarton[] columna)
        {
            var msg = "";
            foreach (var item in columna)
            {
                msg += item.ToString() + ",";
            }
            return msg;
        }

        private string ImprimirColumnaValores(CampoCarton[] columna)
        {
            var msg = "";
            foreach (var item in columna)
            {
                msg += item.valor + ",";
            }
            return msg;
        }


        public string ImprimirValoresCarton()
        {
            var msg = "";
            foreach (var columna in carton)
            {
                msg += ImprimirColumnaValores(columna.Value);
            }
            return msg;
        }

        public CampoCarton[] GenerarColumnaBingo(string columna, int intervalo)
        {
            int[] valoresColumna = Herramientas.CrearArray.CrearRandomArray(5,
                                                                HerramientasJuego.EncontrarIntervaloDeColumna(columna, intervalo)[0],
                                                                HerramientasJuego.EncontrarIntervaloDeColumna(columna, intervalo)[1]);
            CampoCarton[] campos = new CampoCarton[5];
            for (int i = 0; i < valoresColumna.Length; i++)
            {
                campos[i] = new CampoCarton(valoresColumna[i], i, columna);
            }
            return campos;

        }

        public Dictionary<string, CampoCarton[]> GenerarCartonBingo()
        {
            Dictionary<string, CampoCarton[]> cartonTemporal = new Dictionary<string, CampoCarton[]>();
            for (int i=0; i<5; i++)
            {
                string columna = HerramientasJuego.GetNombresDeColumnas()[i];
                cartonTemporal.Add(columna, GenerarColumnaBingo(columna, intervalo));
            }
            return cartonTemporal;
        }



        public List<int> EncontrarNumerosRequeridosParaGanar()
        {
            List<int> numeros = new List<int>();
            foreach (KeyValuePair<string,int> campoAfortunado in this.modalidad.GetCamposAfortunados())
            {
                numeros.Add(carton[campoAfortunado.Key][campoAfortunado.Value].valor);
            }
           
            return numeros;
        }

        public bool esAfortunado(int numero)
        {
            string columna = HerramientasJuego.EncontrarAQueColumnaPertenece(numero, intervalo);
            int posicion = HerramientasJuego.ObtenerCampoDeColumna(numero, carton[columna]);
            if(posicion == -1)
            {
                return false;
            }
            marcarCampo(columna, posicion);
            return true;
        }

        private void marcarCampo(string columna, int posicion)
        {
            carton[columna][posicion].boolJugado = true;
        }

        public bool esGanador(List<int> numerosJugados)
        {
            foreach(int numero in numerosRequeridosParaGanar)
            {
                if(numerosJugados.IndexOf(numero) == -1)
                {
                    return false;
                }
            }
            return true;
        }

       
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class ModalidadJuego
    {
        Dictionary<string, int[]> modalidad { set; get; }

        public ModalidadJuego( Dictionary<string, int[]> modalidad)
        {
            this.modalidad = modalidad;
        }

        public List<KeyValuePair<string, int>> GetCamposAfortunados()
        {
            List<KeyValuePair<string, int>> campos = new List<KeyValuePair<string,int>>();
            foreach (KeyValuePair<string, int[]> keypair in modalidad)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (keypair.Value[i] == 1)
                    {
                        campos.Add(new KeyValuePair<string, int>(keypair.Key, i));
                    }
                }
            }
            return campos;
        }

      
    }
}



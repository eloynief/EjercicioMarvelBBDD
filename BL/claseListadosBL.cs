using DAL;
using Entities;

namespace BL
{
    public class claseListadosBL
    {

        /// <summary>
        /// devuelve la lista de la DAL para pasarla al controller
        /// </summary>
        /// <returns></returns>
        public static List<clasePersonajes> listaPersonajesAzureBL()
        {


            return claseListados.listaPersonajesAzure();

        }

        /// <summary>
        /// devuelve la lista de la DAL para pasarla al controller
        /// </summary>
        /// <returns></returns>
        public static List<claseCombate> listaCombatesAzureBL()
        {


            return claseListados.listaCombatesAzure();

        }




    }
}

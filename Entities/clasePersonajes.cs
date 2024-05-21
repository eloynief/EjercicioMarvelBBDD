namespace Entities
{
    public class clasePersonajes
    {
        #region atributos

        int idPersonaje;
        String nombre;
        String foto;


        #endregion


        #region propiedades

        public int IdPersonaje { get => idPersonaje; set => idPersonaje = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public string Foto { get => foto; set => foto = value; }


        #endregion

        #region constructor

        public clasePersonajes()
        {

        }

        /// <summary>
        /// constructor con parametros
        /// </summary>
        /// <param name="idPersonaje"></param>
        /// <param name="nombre"></param>
        /// <param name="foto"></param>
        public clasePersonajes(int idPersonaje, string nombre, string foto)
        {
            this.idPersonaje = idPersonaje;
            this.nombre = nombre;
            this.foto = foto;
        }
        #endregion




    }
}

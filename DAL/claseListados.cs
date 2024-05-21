using Entities;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class claseListados
    {


        #region metodos/funciones de azure

        /// <summary>
        /// Metodo que saca la lista de personajes de la BBDD de azure
        /// </summary>
        /// <returns></returns>
        public static List<clasePersonajes> listaPersonajesAzure()
        {


            List<clasePersonajes> listado = new List<clasePersonajes>();

            //
            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            clasePersonajes oPersonajes;
            


            try

            {

                miConexion.ConnectionString = EnlaceBBDD.Conexion();

                miConexion.Open();
                

                //Creamos el comando (Creamos el comando, le pasamos la sentencia y la conexion, y lo ejecutamos)

                miComando.CommandText = "SELECT * FROM personajes";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();



                //Si hay lineas en el lector

                if (miLector.HasRows)

                {
                    //
                    while (miLector.Read())

                    {

                        //

                        oPersonajes = new clasePersonajes();

                        oPersonajes.IdPersonaje = (int)miLector["IdPersonaje"];

                        oPersonajes.Nombre = (string)miLector["Nombre"];



                        //comprobamos si los valores introducidos no son null

                        //Si sospechamos que el campo de la fechaNac puede ser Null en la BBDD


                        if (miLector["Foto"] != System.DBNull.Value)
                        {
                            oPersonajes.Foto = (string)miLector["Foto"];
                        }


                        listado.Add(oPersonajes);

                    }

                }

                miLector.Close();

                miConexion.Close();





            }

            catch (SqlException exSql)

            {

                throw exSql;

            }


            return listado;




        }


        /// <summary>
        /// Metodo que saca la lista de personajes de la BBDD de azure
        /// </summary>
        /// <returns></returns>
        public static List<claseCombate> listaCombatesAzure()
        {
            List<claseCombate> listadoCombates = new List<claseCombate>();

            //
            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            claseCombate oCombates;

            try
            {

                miConexion.ConnectionString = EnlaceBBDD.Conexion();

                miConexion.Open();
                

                //Creamos el comando (Creamos el comando, le pasamos la sentencia y la conexion, y lo ejecutamos)

                miComando.CommandText = "SELECT * FROM personajes";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();


                //Si hay lineas en el lector

                if (miLector.HasRows)
                {

                    while (miLector.Read())
                    {
                        //
                        oCombates=new claseCombate();



                        oCombates.Fecha = (DateTime)miLector["Fecha"];


                        oCombates.IdPersonaje1 = (int)miLector["IdPersonaje1"];

                        oCombates.IdPersonaje2 = (int)miLector["IdPersonaje2"];


                        oCombates.Puntuacion1 = (int)miLector["PuntuacionPersonaje1"];

                        oCombates.Puntuacion2 = (int)miLector["PuntuacionPersonaje2"];



                    }


                }


            }
            catch (SqlException exSql)
            {

                throw exSql;

            }



            return listadoCombates;
        }

        #endregion



    }
}

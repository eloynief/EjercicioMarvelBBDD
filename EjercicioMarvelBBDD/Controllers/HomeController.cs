using BL;
using EjercicioMarvelBBDD.Models;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjercicioMarvelBBDD.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// 0.
        /// Pagina principal
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }









        /// <summary>
        /// 2.
        /// Funcion para mostrar una lista de los personajes sacado de la BL que usa los datos de la DAL
        /// </summary>
        /// <returns></returns>
        public IActionResult listaPersonajesAzure()
        {
            List<clasePersonajes> lista = claseListadosBL.listaPersonajesAzureBL();

            //lista.OrderBy(a => a.IdPersonaje).ToList();


            //devuelve la vista de la BL
            return View(lista);
        }

        /// <summary>
        /// 3.
        /// Funcion para mostrar una lista de los combates sacado de la BL que usa los datos de la DAL
        /// </summary>
        /// <returns></returns>
        public IActionResult listaCombatesAzure()
        {
            List<claseCombate> lista = claseListadosBL.listaCombatesAzureBL();

            //lista.OrderBy(a => a.IdPersonaje).ToList();


            //devuelve la vista de la BL
            return View(lista);
        }

















    }
}

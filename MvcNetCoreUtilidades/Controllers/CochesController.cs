using Microsoft.AspNetCore.Mvc;
using MvcNetCoreUtilidades.Models;
using MvcNetCoreUtilidades.Repositories;
using System.Runtime.InteropServices;

namespace MvcNetCoreUtilidades.Controllers
{
    public class CochesController : Controller
    {
        private RepositoryCoches repo;

        public CochesController(RepositoryCoches repo)
        {
            this.repo = repo;
        }

        public IActionResult Details(int idcoche)
        {
            Coche car = this.repo.FindCoche(idcoche);
            return View(car);
                
        }

        //ESTA SERA LA VISTA PRINCIPAL
        public IActionResult Index()
        {
            return View();
        }

        //TENDREMOS UN IACTIONRESULT PARCIAL 
        //PARA INTEGRAR DENTRO DE INDEX
        public IActionResult _CochesPartial()
        {
            //DEBEMOS DEVOLVER EL DIBUJO QUE DESEEMOS EN 
            //AJAX.  INDICAMOS EL NOMBRE DEL FICHERO
            //CSHTML Y SU MODEL
            List<Coche> cars = this.repo.GetCoches();
            return PartialView("_CochesPartial", cars);
        }

        public IActionResult _CochesDetails(int idcoche)
        {
            Coche car = this.repo.FindCoche(idcoche);
            return PartialView("_CochesDetailsView", car);
        }
    }
}

using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Autoridades.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace Autoridades.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {


        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get { return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }
            set { _userManager = value; }
        }

        private ApplicationDbContext _dbContext;

        public ApplicationDbContext DbContext
        {
            get { return _dbContext ?? HttpContext.GetOwinContext().GetUserManager<ApplicationDbContext>(); }
            set { _dbContext = value; }
        }

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Informacoes()
        {
            return View();
        }
    }
}
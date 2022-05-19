using Microsoft.AspNetCore.Mvc;
using HW_11.infrastructure.DataAccess;

namespace HW_11.Controllers
{
    public class Store : Controller
    {
        FactorRpository O_FRepository;
        public Store()
        {
            O_FRepository=new FactorRpository();
        }
        public IActionResult Index()
        {
            var factolist= O_FRepository.GetAllFactor();
            return View(factolist);
        }
        public IActionResult SellerDetail(int id)
        {
            var S_O= O_FRepository.SellerDetail(id);
            return View(S_O);
        }

        public IActionResult ProducterDetail(int id)
        {
            var P_O = O_FRepository.ProducterDetail(id);
            return View(P_O);
        }
        public IActionResult CustomerrDetail(int id)
        {
            var P_O = O_FRepository.CustomererDetail(id);
            return View(P_O);
        }
      
        public IActionResult sabtfactor()
        {
            return View();
        }
    }
}

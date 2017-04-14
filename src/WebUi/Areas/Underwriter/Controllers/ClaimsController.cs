using System.Web.Mvc;
using EDeviceClaims.Domain.Services;
using EDeviceClaims.WebUi.Areas.Underwriter.Models;
using EDeviceClaims.WebUi.Controllers;

namespace EDeviceClaims.WebUi.Areas.Underwriter.Controllers
{
    public class ClaimsController : AppController
    {
        private IPolicyService _policyService = new PolicyService();
        private IClaimsService _claimServices = new ClaimsService();

        // GET: Underwriter/Device
        public ActionResult Index()
        {
            var claims = _claimServices.GetAllOpen();

            var model = new ClaimsListViewModel(claims);
            return View("Index", model);
        }
    }
}
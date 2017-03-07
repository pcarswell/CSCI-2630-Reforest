using EDeviceClaims.Domain.Services;
using EDeviceClaims.WebUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EDeviceClaims.Domain.Models;

namespace EDeviceClaims.WebUi.Controllers
{
    [Authorize]
    public class ClaimsController : AppController
    {
        private IPolicyService _policyService = new PolicyService();
        private IClaimsService _claimsService = new ClaimsService();
        // GET: Claims 
        public ActionResult NewClaim(Guid id)
        {
            var domainModel = _policyService.GetById(id);
            var model = new DeviceViewModel(domainModel);
            return View(model);
        }

        public ActionResult Start(Guid id)
        {
            var domainModel = _claimsService.StartClaim(id);
            var model = new ClaimViewModel(domainModel);

            return View("Details", model);
        }

        
        public ActionResult Details()
        {
            return null;
        }
    }
}
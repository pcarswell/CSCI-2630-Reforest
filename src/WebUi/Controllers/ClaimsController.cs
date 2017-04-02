using EDeviceClaims.Domain.Services;
using EDeviceClaims.WebUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EDeviceClaims.Core;
using EDeviceClaims.Domain.Models;

namespace EDeviceClaims.WebUi.Controllers
{
    [Authorize(Roles = ApplicationRoles.PolicyHolder)]
    public class ClaimsController : AppController
    {
        //private IPolicyService _policyService = new PolicyService();
        private IClaimsService _claimsService = new ClaimsService();
        // GET: Claims 
        

        public ActionResult Start(Guid id)
        {
            var claimDomainModel = _claimsService.StartClaim(id);
            var model = new ClaimViewModel(claimDomainModel);

            return View(model);
        }

        public ActionResult Edit(Guid id)
        {
            var claimDomainModel =  _claimsService.GetById(id);
            var model = new ClaimViewModel(claimDomainModel);
            return View(model);
        }
        
        public ActionResult Details(Guid id)
        {
            return null;
        }
    }
}
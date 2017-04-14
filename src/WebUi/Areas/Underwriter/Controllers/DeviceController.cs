using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EDeviceClaims.Core;
using EDeviceClaims.Domain.Services;
using EDeviceClaims.WebUi.Controllers;

namespace EDeviceClaims.WebUi.Area.Underwriter.Controllers
{

    

    [Authorize(Roles = ApplicationRoles.Underwriter)]
    public class UnderwriterAppController : AppController
    {
        
    }

}
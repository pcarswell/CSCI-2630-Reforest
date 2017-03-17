using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EDeviceClaims.Domain.Models;

namespace EDeviceClaims.WebUi.Models
{
    public class ClaimViewModel
    {
        public ClaimViewModel()
        {

        }

        public ClaimViewModel(ClaimDomainModel domainModel)
        {
            Id = domainModel.Id;
        }

        public Guid Id { get; set; }
        
    }
}
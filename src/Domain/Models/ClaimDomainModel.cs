using EDeviceClaims.Core;
using EDeviceClaims.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDeviceClaims.Domain.Models
{
    public class ClaimsListViewModel
    {
        public ClaimsListViewModel(ClaimEntity claim)
        {
            Id = claim.Id;
            WhenStarted = claim.WhenCreated;
            Policy = new PolicyDomainModel(claim.Policy);
            Status = claim.Status;
        }

        public DateTime WhenStarted { get; set; }
        public Guid Id { get; set; }
        public PolicyDomainModel Policy { get; set; }

        public ClaimStatus Status { get; set; }
    }
}

using EDeviceClaims.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDeviceClaims.Domain.Models
{
    public class ClaimDomainModel
    {
        public ClaimDomainModel(ClaimEntity claim)
        {
            Id = claim.Id;
            WhenStarted = claim.WhenCreated;
        }

        public Guid Id { get; set; }
        public DateTime WhenStarted { get; set; }
    }
}

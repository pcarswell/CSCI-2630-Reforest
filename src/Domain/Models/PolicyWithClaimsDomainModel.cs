using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDeviceClaims.Entities;

namespace EDeviceClaims.Domain.Models
{
    public class PolicyDomainModel
    {
        public PolicyDomainModel(PolicyEntity policyEntity)
        {
            Id = policyEntity.Id;
            Number = policyEntity.Number;
            SerialNumber = policyEntity.SerialNumber;
            DeviceName = policyEntity.DeviceName;
            WhenCreated = policyEntity.WhenCreated;
            WhenLastUpdated = policyEntity.WhenLastModified;
        }
        public Guid Id { get; set; }

        public string Number { get; set; }

        public string DeviceName { get; set; }

        public string SerialNumber { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime? WhenLastUpdated { get; set; }
    }
    public class PolicyWithClaimsDomainModel : PolicyDomainModel
    {
        public PolicyWithClaimsDomainModel(PolicyEntity policyEntity) : base(policyEntity)
        {
            LoadsClaims(policyEntity.Claims);
        }

        private void LoadsClaims(IReadOnlyCollection<ClaimEntity> claims)
        {
            if (claims == null) return;

            foreach (var claim in claims)
            {
                Claims.Add(new ClaimsListViewModel(claim));
            }
        }
        
        public List<ClaimsListViewModel> Claims { get; set; } = new List<ClaimsListViewModel>();
    }
}

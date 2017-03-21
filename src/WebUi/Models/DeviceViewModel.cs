using System;
using EDeviceClaims.Domain.Models;
using System.Linq;

namespace EDeviceClaims.WebUi.Models
{
    public class DeviceViewModel
    {
        public DeviceViewModel(PolicyDomainModel policy)
        {
            PolicyId = policy.Id;
            PolicyNumber = policy.Number;
            SerialNumber = policy.SerialNumber;
            Name = policy.DeviceName;
            WhenCreated = policy.WhenCreated;
            WhenLastUpdated = policy.WhenLastUpdated;
            //HasPendingClaim = thing.Claims.Any();
            MostCurrentClaim = (policy.Claims.Any()) ? new ClaimViewModel(policy.Claims.First()) : null;
        }

        public string Name { get; set; }

        public string SerialNumber { get; set; }

        public string PolicyNumber { get; set; }

        public Guid PolicyId { get; set; }

        public ClaimViewModel MostCurrentClaim { get; set; }

        public DateTime WhenCreated { get; set; }
        public DateTime? WhenLastUpdated { get; set; }

        public bool ShowViewClaimButton()
        {
            return MostCurrentClaim != null;
        }
    }
}
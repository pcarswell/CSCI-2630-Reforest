using System;
using EDeviceClaims.Domain.Models;

namespace EDeviceClaims.WebUi.Models
{
    public class DeviceViewModel
    {
        public DeviceViewModel(PolicyDomainModel thing)
        {
            PolicyId = thing.Id;
            PolicyNumber = thing.Number;
            SerialNumber = thing.SerialNumber;
            Name = thing.DeviceName;
            WhenCreated = thing.WhenCreated;
            WhenLastUpdated = thing.WhenLastUpdated;
            HasPendingClaim = false;
        }

        public string Name { get; set; }

        public string SerialNumber { get; set; }

        public string PolicyNumber { get; set; }

        public Guid PolicyId { get; set; }

        public bool HasPendingClaim { get; set; }

        public DateTime WhenCreated { get; set; }
        public DateTime? WhenLastUpdated { get; set; }
    }
}
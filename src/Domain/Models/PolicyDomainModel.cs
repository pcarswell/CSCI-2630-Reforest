﻿using System;
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
            Claims = new List<ClaimDomainModel>();

            foreach(var claim in policyEntity.Claims)
            {
                Claims.Add(new ClaimDomainModel(claim));
            }
        }

        public Guid Id { get; set; }

        public string Number { get; set; }

        public string DeviceName { get; set; }

        public string SerialNumber { get; set; }

        public DateTime WhenCreated { get; set; }
        public DateTime? WhenLastUpdated { get; set; }
        public List<ClaimDomainModel> Claims { get; set; }
    }
}

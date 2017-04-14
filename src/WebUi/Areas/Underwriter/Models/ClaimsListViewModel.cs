using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EDeviceClaims.Domain.Models;
using EDeviceClaims.Core;

namespace EDeviceClaims.WebUi.Areas.Underwriter.Models
{
    public class ClaimsListViewModel : List<UnderwriterClaimViewModel>
    {
        public ClaimsListViewModel(List<Domain.Models.ClaimsListViewModel> claims)
        {
            foreach (var claim in claims)
            {
                Add(new UnderwriterClaimViewModel(claim));
            }
        }
    }

    public class UnderwriterClaimViewModel
    {
        public UnderwriterClaimViewModel(Domain.Models.ClaimsListViewModel claim)
        {
            Id = claim.Id;
            PolicyId = claim.Policy.Id;
            Name = claim.Policy.DeviceName;
            Start = $"{claim.WhenStarted.ToShortDateString()} {claim.WhenStarted.ToShortDateString()}";

            Status = claim.Status.ToString();
        }
        public Guid Id {  get; set; }
        public Guid PolicyId { get; set; }
        public string Name { get; set; }
        public string Start { get; set; }
        public string Status { get; set; }
    }
}
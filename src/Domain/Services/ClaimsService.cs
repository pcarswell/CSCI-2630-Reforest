using EDeviceClaims.Domain.Models;
using EDeviceClaims.Interactors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDeviceClaims.Domain.Services
{
    public interface IClaimsService
    {
        ClaimDomainModel StartClaim(Guid policyId);
    }

    public class ClaimsService : IClaimsService
    {
        private IGetPolicyInteractor GetPolicyInteractor
        {
            get { return _getPolicyInteractor ?? (_getPolicyInteractor = new GetPolicyInteractor()); }
            set { _getPolicyInteractor = value; }
        }
        private IGetPolicyInteractor _getPolicyInteractor;

        private ICreateClaimsInteractor CreateClaimsInteractor
        {
            get { return _createClaimsInteractor ?? (_createClaimsInteractor = new CreateClaimsInteractor()); }
            set { _createClaimsInteractor = value; }
        }

        private ICreateClaimsInteractor _createClaimsInteractor;
        
        public ClaimDomainModel StartClaim(Guid policyId)
        {
            var policy = GetPolicyInteractor.GetById(policyId);

            if (policy == null) throw new ArgumentException("Policy for that Policy Id does not exist");

            var claim = CreateClaimsInteractor.Execute(policyId);
            //var existingClaim = CreateClaimsInteractor.GetByPolicyId(policyId);
            return new ClaimDomainModel(claim);
        }
    }
}

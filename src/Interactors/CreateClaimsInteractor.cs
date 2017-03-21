using EDeviceClaims.Entities;
using EDeviceClaims.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDeviceClaims.Interactors
{
    public interface ICreateClaimsInteractor
    {
        //ClaimEntity GetByPolicyId(Guid policyId);
        ClaimEntity Execute(Guid policyId);
    }

    public class CreateClaimsInteractor : ICreateClaimsInteractor
    {
        private IClaimRepository Repo
        {
            get { return _repo ?? (_repo = new ClaimRepository()); }
            set { _repo = value; }
        }
        private IClaimRepository _repo;

        public CreateClaimsInteractor()
        {

        }

        public CreateClaimsInteractor(IClaimRepository claimRepo)
        {
            _repo = claimRepo;
        }

        //public ClaimEntity GetByPolicyId(Guid policyId)
        //{
        //    return Repo.GetByPolicyId(policyId);
        //}

        public ClaimEntity Execute(Guid policyId)
        {
            var newClaim = new ClaimEntity { Id = Guid.NewGuid(), PolicyId = policyId };
            newClaim = Repo.Create(newClaim);

            return newClaim;
        }
    }
}

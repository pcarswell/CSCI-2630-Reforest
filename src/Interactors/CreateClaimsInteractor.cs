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
        ClaimEntity GetByPolicyId(Guid policyId);
        ClaimEntity Execute(Guid policyId);
    }

    public class CreateClaimsInteractor : ICreateClaimsInteractor
    {
        private IClaimsRepository Repo
        {
            get { return _repo ?? (_repo = new ClaimsRepository()); }
            set { _repo = value; }
        }
        private IClaimsRepository _repo;

        public ClaimEntity GetByPolicyId(Guid policyId)
        {
            return Repo.GetByPolicyId(policyId);
        }

        public ClaimEntity Execute(Guid policyId)
        {
            return new ClaimEntity { Id = Guid.NewGuid(), PolicyId = policyId };
        }
    }
}

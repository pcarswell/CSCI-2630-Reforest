using EDeviceClaims.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDeviceClaims.Repositories
{
    public interface IClaimRepository : IEfRepository<ClaimEntity, Guid>
    {
        //ClaimEntity GetByPolicyId(Guid policyId);
    }

    public class ClaimRepository : EfRepository<ClaimEntity, Guid>, IClaimRepository
    {
        public ClaimRepository() : base (new EDeviceClaimsUnitOfWork())
        {

        }

        public ClaimRepository(IEfUnitOfWork unitOfWork) : base (unitOfWork)
        {

        }
        //public ClaimEntity GetByPolicyId(Guid policyId)
        //{

        //    return ObjectSet
        //    .FirstOrDefault(c => c.PolicyId == policyId);
        //}
    }
}

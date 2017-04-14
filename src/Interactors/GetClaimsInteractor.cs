using EDeviceClaims.Entities;
using EDeviceClaims.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDeviceClaims.Interactors
{
    public interface IGetClaimsInteractor
    {
        ClaimEntity Execute(Guid id);
        List<ClaimEntity> GetAllOpen();
    }

    public class GetClaimsInteractor : IGetClaimsInteractor
    {
        private IClaimRepository Repo
        {
            get { return _repo ?? (_repo = new ClaimRepository()); }
            set { _repo = value; }
        }
        private IClaimRepository _repo;

        public GetClaimsInteractor()
        {

        }

        public GetClaimsInteractor(IClaimRepository claimRepo)
        {
            _repo = claimRepo;
        }

        public ClaimEntity Execute(Guid id)
        {
            return Repo.GetById(id);
        }

        public List<ClaimEntity> GetAllOpen()
        {
            return Repo.GetAllOpen();
        }
    }
}

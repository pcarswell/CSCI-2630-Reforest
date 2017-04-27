using EDeviceClaims.Entities;
using EDeviceClaims.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDeviceClaims.Interactors
{
    public interface IGetUserInteractor
    {
        AuthorizedUser GetById(string userId);
    }

    public class GetUserInteractor : IGetUserInteractor
    {
        private IUserRepository Repo
        {
            get { return _repo ?? (_repo = new UserRepository()); }
            set { _repo = value; }
        }
        private IUserRepository _repo;

        public GetUserInteractor() { }

        public GetUserInteractor(IUserRepository userRepo)
        {
            _repo = userRepo;
        }

        public AuthorizedUser GetById(string userId)
        {
            return Repo.GetById(userId);
        }
    }
}

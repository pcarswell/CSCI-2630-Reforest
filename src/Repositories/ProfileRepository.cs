﻿using EDeviceClaims.Entities;

namespace EDeviceClaims.Repositories
{
    public interface IProfileRepository : IEfRepository<AuthorizedUser, string>
    {
        

    }

    public class ProfileRepository : EfRepository<AuthorizedUser, string>, IProfileRepository
    {
        public ProfileRepository() : base(new EDeviceClaimsUnitOfWork())
        {
        }

        public ProfileRepository(IEfUnitOfWork unitOfWork) : base(unitOfWork) { }

        
    }
}
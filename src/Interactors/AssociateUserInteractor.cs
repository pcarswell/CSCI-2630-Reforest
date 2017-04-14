using EDeviceClaims.Entities;
using EDeviceClaims.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDeviceClaims.Interactors
{
    public interface IAssociateUserInteractor
    {
        //void Execute(PolicyEntity policy);
    }

    public class AssociateUserInteractor : IAssociateUserInteractor
    {
        //First Get the repo
        private IPolicyRepository Repo
        {
            get { return _repo ?? (_repo = new PolicyRepository()); }
            set { _repo = value; }
        }
        private IPolicyRepository _repo;

        //Create the constructors
        public AssociateUserInteractor() { }
        
        public  AssociateUserInteractor(IPolicyRepository policyRepo)
        {
            _repo = policyRepo;
        }

        //Create the Execute method that returns a PolicyEntity?
        //public void Execute(PolicyEntity devices)
        //{
            
        //    Repo.EfUnitOfWork.Context.SaveChanges();
        //}


    }
}

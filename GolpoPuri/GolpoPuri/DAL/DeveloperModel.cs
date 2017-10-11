using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GolpoPuri.Library;


namespace GolpoPuri.DAL
{
    public class DeveloperModel : IDeveloperModel
    {
        private IUnitOfwork DeveloperUnitOfWork;

        public DeveloperModel(IUnitOfwork DeveloperUnitOfWork)
        {
            this.DeveloperUnitOfWork = DeveloperUnitOfWork;
        }

        //public Developer CreateDev(string Name , string PhotoUrl , string role ,string linkdin, string facebook , string github , string stckoverflow)
        //{
        //    var _dev = new Developer();
        //    _dev.Id = Guid.NewGuid();
        //    _dev.PhotoUrl = PhotoUrl;
        //    _dev.Role = role;
        //    _dev.FacebookID = facebook;
        //    _dev.GitHubID = github;
        //    _dev.LinkedInID = linkdin;
        //    _dev.StackoverflowID = stckoverflow;
        //    DeveloperUnitOfWork.DevelopperRepository.insert(_dev);
        //    DeveloperUnitOfWork.Save();
            
        //    return _dev;
        //}

        public Developer CreateDev(Developer dev)
        {
            var _dev = new Developer();
            _dev.Id = Guid.NewGuid();
            _dev.PhotoUrl = dev.PhotoUrl;
            _dev.Role = dev.Role;
            _dev.FacebookID = dev.FacebookID;
            _dev.GitHubID = dev.GitHubID;
            _dev.LinkedInID = dev.LinkedInID;
            _dev.StackoverflowID = dev.StackoverflowID;

            DeveloperUnitOfWork.DevelopperRepository.insert(_dev);
            DeveloperUnitOfWork.Save();

            return _dev;
        }
    }
}
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
            if (string.IsNullOrEmpty(dev.PhotoUrl))
            {
                _dev.PhotoUrl = "";
            }
            else
                _dev.PhotoUrl = dev.PhotoUrl;

            if (string.IsNullOrEmpty(_dev.Role))
            {
                _dev.PhotoUrl = "";
            }
            else
                _dev.Role = dev.Role;

            if (string.IsNullOrEmpty(_dev.FacebookID))
            {
                _dev.FacebookID = "";
            }
            else
                _dev.FacebookID = dev.FacebookID;


            if (string.IsNullOrEmpty(_dev.GitHubID))
            {
                _dev.GitHubID = "";
            }
            else
                _dev.GitHubID = dev.GitHubID;

            if (string.IsNullOrEmpty(_dev.LinkedInID))
            {
                _dev.LinkedInID = "";
            }
            else
                _dev.LinkedInID = dev.LinkedInID;

            if (string.IsNullOrEmpty(_dev.StackoverflowID))
            {
                _dev.StackoverflowID = "";
            }
            else
                _dev.StackoverflowID = dev.StackoverflowID;

            DeveloperUnitOfWork.DevelopperRepository.insert(_dev);
            DeveloperUnitOfWork.Save();

            return _dev;
        }
    }
}
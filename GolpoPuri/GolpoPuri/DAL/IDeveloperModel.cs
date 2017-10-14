using GolpoPuri.Library;

namespace GolpoPuri.DAL
{
    public interface IDeveloperModel
    {
        //Developer CreateDev(string Name, string PhotoUrl, string role, string linkdin, string facebook, string github, string stckoverflow);
        void CreateDev(Developer dev);
    }
}
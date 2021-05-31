using SchoolDiaryMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDiaryMVC.Services
{
    public interface IUserService
    {
        UserAddressViewModel GetProfile(string id);
    }
}

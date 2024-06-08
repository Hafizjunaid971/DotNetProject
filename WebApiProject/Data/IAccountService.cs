using System.Threading.Tasks;
using WebApiProject.BusinessModel;

namespace WebApiProject.Data
{
    public interface IAccountService
    {
        Task<ResponseModel> Login(LoginModel user);
    }
}

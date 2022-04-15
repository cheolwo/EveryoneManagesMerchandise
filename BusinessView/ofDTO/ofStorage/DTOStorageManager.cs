using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofDTO.ofStorage
{
    public enum DTOStorageForUser { Employee, Employer, Platform}
    public enum DTOStorageForBusiness { Logister, Orderer, Producter, Forwarder, Delivery}
    public class DTOStorageOption
    {
        public DTOStorageForUser DTOStorageForUser { get; set; }
        public DTOStorageForBusiness DTOStorageForBusiness { get; set; }
    }

    // Option 이 제어흐름을 결정한다.
    public interface IDTOStorageManager<T> where T : class
    {
        T GetById(string id);
        T Add(T t);
        void Delete(T t);
        T Update(string id, T t);
    }
    public class DTOStorageManager
    {
        private DTOStorageOption _dtoStorageOptions;
        private UserDTOStorage UserDTOStorage { get; set; }
        public DTOStorageManager(DTOStorageOption dtoStorageOptions)
        {
            _dtoStorageOptions = dtoStorageOptions;
        }
        public void UserStorageBuilder()
        {
            switch (_dtoStorageOptions.DTOStorageForUser)
            {
                case DTOStorageForUser.Employee:
                    UserDTOStorage = new EmployeeDTOStorage();
                    break;
                case DTOStorageForUser.Employer:
                    UserDTOStorage = new EmployerDTOStorage();
                    break;
                case DTOStorageForUser.Platform:
                    UserDTOStorage = new PlatformDTOStorage();
                    break;
            }
        }
    }
    public class UserDTOStorage
    {

    }
}
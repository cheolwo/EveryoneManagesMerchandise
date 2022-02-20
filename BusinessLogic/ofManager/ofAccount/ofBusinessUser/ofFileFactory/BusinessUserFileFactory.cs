using BusinessData.ofAccount.ofModel;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessLogic.ofManager.ofAccount.ofBusinessUser.ofFileFactory
{
    public interface IBusinessUserFileFactory : IEntityFileFactory<BusinessUser>
    {

    }
    public class BusinessUserFileFactory : IBusinessUserFileFactory
    {
        public object[,] InitExcelData(string fileconnection)
        {
            throw new NotImplementedException();
        }

        public List<BusinessUser> SetExcelEntities(object[,] datas, Dictionary<PropertyInfo, int> Target)
        {
            throw new NotImplementedException();
        }
    }
}

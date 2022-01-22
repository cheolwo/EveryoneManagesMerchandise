using BusinessData;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessLogic.ofManager.ofGeneric.ofFileFactory
{
    public interface IEntityFileFactory<TEntity> where TEntity : Entity
    {
        object[,] InitExcelData(string fileconnection);
        List<TEntity> SetExcelEntities(object[,] datas, Dictionary<PropertyInfo, int> Target);
    }
    public class EntityFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Entity, new()
    {
        Application Application { get; set; }
        Workbook Workbook { get; set; }
        Worksheet Worksheet { get; set; }
        public EntityFileFactory()
        {
        }
        public object[,] InitExcelData(string fileconnection)
        {
            Application = new Application();
            Workbook = null;
            Worksheet = null;
            Workbook = Application.Workbooks.Open(fileconnection);
            if (Workbook != null)
            {
                Worksheet = Workbook.Worksheets.get_Item(1) as Worksheet;
                return Worksheet.UsedRange.Value;
            }
            throw new ArgumentNullException("WorkBool Is Null");
        }

        public List<TEntity> SetExcelEntities(object[,] datas, Dictionary<PropertyInfo, int> Target)
        {
            var properties = typeof(TEntity).GetProperties();
            var Keys = Target.Keys;
            int i = 2;
            List<TEntity> entities = new();
            try
            {
                while (datas[i, 2] != null)
                {
                    TEntity entity = new();
                    foreach (var key in Keys)
                    {
                        foreach (var prop in properties)
                        {
                            if (key.Equals(prop))
                            {
                                prop.SetValue(entity, datas[i, Target[key]].ToString());
                                break;
                            }
                        }
                    }
                    var findentity = entities.Find(e => e.Equals(entity));
                    if (findentity == null)
                    {
                        entities.Add(entity);
                        i++;
                    }
                    else
                    {
                        entity = null;
                        i++;
                    }
                }
            }
            catch
            {
                return entities;
            }
            return entities;
        }
    }
    public interface ICenterFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Center
    {
        Dictionary<string, List<TEntity>> SetExcelCenters(object[,] datas, Dictionary<PropertyInfo, int> Target, int UserTarget);
    }
    public class CenterFileFactory<TEntity> : EntityFileFactory<TEntity>, ICenterFileFactory<TEntity> where TEntity : Center, new()
    {
        public Dictionary<string, List<TEntity>> SetExcelCenters(object[,] datas, Dictionary<PropertyInfo, int> Target, int UserTarget)
        {
            var properties = typeof(TEntity).GetProperties();
            Dictionary<string, List<TEntity>> keyValuePairs = new Dictionary<string, List<TEntity>>();
            List<TEntity> entities = new();
            var Keys = Target.Keys;
            int i = 2;
            try
            {
                while (datas[i, 2] != null)
                {
                    TEntity entity = new();
                    foreach (var key in Keys) // Excel To Entity
                    {
                        foreach (var prop in properties)
                        {
                            if (key.Equals(prop))
                            {
                                prop.SetValue(entity, datas[i, Target[key]].ToString());
                                break;
                            }
                        }
                    }
                    var findentity = entities.Find(e => e.Equals(entity));
                    if (findentity == null) // 중복성 체크
                    {
                        entities.Add(entity);
                        string UserCode = datas[i, UserTarget].ToString();
                        var values = keyValuePairs[UserCode];
                        if (values.Count > 0 || values == null) // 초기값 확인 및 저장
                        {
                            List<TEntity> newValues = new();
                            newValues.Add(entity);
                            keyValuePairs.Add(UserCode, newValues);
                            i++;
                        }
                        else // UserCode 관계성을 맺어 데이터  저장
                        {
                            values.Add(entity);
                            i++;
                        }
                    }
                    else
                    {
                        entity = null;
                        i++;
                    }
                }
            }
            catch
            {
                return keyValuePairs;
            }
            return keyValuePairs;
        }
    }
    public interface ICommodityFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Entity
    {

    }
    public class CommodityFileFactory<TEntity> : EntityFileFactory<TEntity>, ICommodityFileFactory<TEntity> where TEntity : Commodity, new()
    {

    }
    public interface IStatusFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Status
    {

    }
    public class StatusFileFactory<TEntity> : EntityFileFactory<TEntity>, IStatusFileFactory<TEntity> where TEntity : Status, new()
    {

    }
}

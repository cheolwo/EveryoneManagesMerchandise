//using BusinessData;
//using BusinessData.ofAccount.ofModel;
//using BusinessData.ofCommon.ofInterface;
//using BusinessLogic.ofManager.ofGeneric;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Identity;
//using System.Reflection;

using System.Reflection;

namespace PlatformManager.ofComponent.ofGeneric
{
    public enum TableManagedMode { Dialog, Page }
    public enum TableViewMode { Get, Detail }
    public class TableOption
    {
        private TableViewMode TableViewMode { get; set; }
        private TableManagedMode TableManagedMode { get; set; }
        private bool IsUserTableSetting { get; set; }
        public TableOption(TableViewMode tableViewMode, TableManagedMode tableManagedMode)
        {
            TableViewMode = tableViewMode;
            TableManagedMode = tableManagedMode;
            IsUserTableSetting = false;
        }
        public void IsSetUserSettingTable() { IsUserTableSetting = true; }
        public TableOption(string tableView, string tableManagedMode)
        {
            if (tableView.Equals(TableViewMode.Get.ToString()))
            {
                TableViewMode = TableViewMode.Get;
            }
            else
            {
                TableViewMode = TableViewMode.Detail;
            }
            if (tableManagedMode.Equals(TableManagedMode.Dialog.ToString()))
            {
                TableManagedMode = TableManagedMode.Dialog;
            }
            else
            {
                TableManagedMode = TableManagedMode.Page;
            }
        }
        public TableViewMode GetTableViewMode()
        {
            return TableViewMode;
        }
        public TableManagedMode GetTableManagedMode()
        {
            return TableManagedMode;
        }
    }
    public class TableInfo
    {
        private PropertyInfo PropertyInfo { get; set; }
        private Dictionary<string, PropertyInfo> keyValuePairs { get; set; }
        public TableInfo(PropertyInfo propertyInfo)
        {
            PropertyInfo = propertyInfo;
            keyValuePairs = new();
        }
        public PropertyInfo GetOrigin()
        {
            return PropertyInfo;
        }
        public TableInfo()
        {
            keyValuePairs = new();
        }
        public void Add(string name, PropertyInfo propertyInfo)
        {
            keyValuePairs.Add(name, propertyInfo);
        }
        public IEnumerable<string> GetKeys()
        {
            return keyValuePairs.Keys;
        }
        public PropertyInfo GetValueByKey(string key)
        {
            return keyValuePairs[key];
        }
    }
}
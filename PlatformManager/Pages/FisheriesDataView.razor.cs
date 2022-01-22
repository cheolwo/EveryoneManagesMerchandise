using BusinessData;
using BusinessData.ofCommon.ofFisheries.ofModel;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManagement;
using BusinessLogic.ofManager.ofFisheries;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace PlatformManager.Pages
{
    public partial class FisheriesDataView : ComponentBase
    {
        [Inject] public IEntityManager<Warehouse> entityManager { get; set; }
        [Inject] public ICenterManager<Warehouse> centerMangaer { get; set; }
        [Inject] public FisheriesAPIManager FisheriesAPIManager { get; set; }
        [Inject] public FisheriesManagement FisheriesManagement { get; set; }
        private const string FisheriesCodeFilePath = @"C:\\Users\\user\\Downloads\\해양수산부_수산물 수협창고 재고정보_20211231.csv";
        [Inject] public IEntityManager<Copartnership> CopartnershipManager { get; set; }
        public string name { get; set; }
        protected override async Task OnInitializedAsync()
        {
        }
        public async Task ExcelCopartnershipToDb()
        {
            var properties = typeof(Copartnership).GetProperties();
            Dictionary<PropertyInfo, int> TargetColumn = new();
            foreach(var prop in properties)
            {
                if(prop.Name.Equals("Name"))
                {
                    TargetColumn.Add(prop, 5);
                    continue;
                }
                if(prop.Name.Equals("Code"))
                {
                    TargetColumn.Add(prop, 1);
                    continue;
                }
            }
            try
            {
                await CopartnershipManager.ExcelToDb(FisheriesCodeFilePath, TargetColumn);
            }
            catch (Exception ex)
            {
                name = ex.Message;
            }
        }
        public async Task ExcelUserAndCenterToDb()
        {
            Dictionary<Entity, Dictionary<PropertyInfo, int>> Targets = new();
            var userProperties = typeof(Copartnership).GetProperties();
            Dictionary<PropertyInfo, int> UserTargetColumn = new();
            foreach (var prop in userProperties)
            {
                if (prop.Name.Equals("Name"))
                {
                    UserTargetColumn.Add(prop, 5);
                    continue;
                }
                if (prop.Name.Equals("Code"))
                {
                    UserTargetColumn.Add(prop, 1);
                    continue;
                }
            }
            Targets.Add(new Copartnership(), UserTargetColumn);
           
            var centerProperties = typeof(Copartnership).GetProperties();
            Dictionary<PropertyInfo, int> CenterTargetColumn = new();
            foreach (var prop in centerProperties)
            {
                if (prop.Name.Equals("Name"))
                {
                    CenterTargetColumn.Add(prop, 6);
                    continue;
                }
                if (prop.Name.Equals("Code"))
                {
                    CenterTargetColumn.Add(prop, 2);
                    continue;
                }
            }
            Targets.Add(new Fisheries(), CenterTargetColumn);
            await FisheriesManagement.ExcelToDb(FisheriesCodeFilePath, Targets);
        }
    }
}

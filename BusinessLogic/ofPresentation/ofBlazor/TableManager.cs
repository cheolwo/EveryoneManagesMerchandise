using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using BusinessData;
using BusinessData.ofAccount.ofModel;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.ofPresentation.ofBlazor
{
    public class TableManager<TEntity> : ComponentBase where TEntity : Entity, IRelationable
    {
        [Inject] public NavigationManager _navigationManager {get; set;}
        [Inject] public IEntityManager<TEntity> _entityManager {get; set;}
        [Inject] public UserManager<BusinessUser> _userManager {get; set;}
        [Inject] public IHttpContextAccessor _httpContextAccessor {get; set;}
        
        public BusinessUser BusinessUser = new BusinessUser();
        public TEntity entity {get; set;}
        public List<TEntity> Entities = new List<TEntity>();
        public Dictionary<int, TEntity> DicEntities = new Dictionary<int, TEntity>();

        protected override async Task OnInitializedAsync()
        {
            Entities = await _entityManager.GetToListAsync();
            DicEntities = _entityManager.ConvertToDic(Entities);
            Assembly assembly = typeof(TEntity).Assembly;
            entity  = (TEntity)assembly.CreateInstance(typeof(TEntity).Name);
            BusinessUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
        }

        public async Task Create()
        {
            try
            {
                await _entityManager.CreateAsync(entity);
            }
            catch (System.Exception)
            {
                _navigationManager.NavigateTo("/");
            }
        }
    }
}
using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric
{
    public class EmployeePageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EmployeeEntity, new()
    {
        public EmployeePostViewModel<TEntity> _EmployeePostViewModel { get; private set; }
        public EmployeePutViewModel<TEntity> _EmployeePutViewModel { get; private set; }
        public EmployeeDeleteViewModel<TEntity> _EmployeeDeleteViewModel { get; private set; }
        public EmployeeGetsViewModel<TEntity> _EmployeeGetsViewModel { get; private set; }
        public EmployeePageViewModel(EmployeePostViewModel<TEntity> postViewModel, EmployeePutViewModel<TEntity> putViewModel, 
                                EmployeeDeleteViewModel<TEntity> deleteViewModel, EmployeeGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployeePostViewModel = postViewModel;
            _EmployeePutViewModel = putViewModel;  
            _EmployeeGetsViewModel = getsViewModel;
            _EmployeeDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployeePostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : EmployeeEntity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : EmployeeEntity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : EmployeeEntity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : EmployeeEntity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }

    public class EmployeeStatusPageViewModel<TEntity> : StatusPageViewModel<TEntity> where TEntity : EmployeeStatus, new()
    {
        public EmployeeStatusPostViewModel<TEntity> _EmployeeStatusPostViewModel { get; private set; }
        public EmployeeStatusPutViewModel<TEntity> _EmployeeStatusPutViewModel { get; private set; }
        public EmployeeStatusDeleteViewModel<TEntity> _EmployeeStatusDeleteViewModel { get; private set; }
        public EmployeeStatusGetsViewModel<TEntity> _EmployeeStatusGetsViewModel { get; private set; }
        public EmployeeStatusPageViewModel(EmployeeStatusPostViewModel<TEntity> postViewModel, EmployeeStatusPutViewModel<TEntity> putViewModel, 
                                EmployeeStatusDeleteViewModel<TEntity> deleteViewModel, EmployeeStatusGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployeeStatusPostViewModel = postViewModel;
            _EmployeeStatusPutViewModel = putViewModel;  
            _EmployeeStatusGetsViewModel = getsViewModel;
            _EmployeeStatusDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployeeStatusPostViewModel<TEntity> : StatusPostViewModel<TEntity> where TEntity : EmployeeStatus, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeStatusPostViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeStatusPutViewModel<TEntity> : StatusPutViewModel<TEntity> where TEntity : EmployeeStatus, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeStatusPutViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeStatusGetsViewModel<TEntity> : StatusGetsViewModel<TEntity> where TEntity : EmployeeStatus, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeStatusGetsViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeStatusDeleteViewModel<TEntity> : StatusDeleteViewModel<TEntity> where TEntity : EmployeeStatus, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeStatusDeleteViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }

    public class EmployeeCommodityPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EmployeeCommodity, new()
    {
        public EmployeeCommodityPostViewModel<TEntity> _EmployeeCommodityPostViewModel { get; private set; }
        public EmployeeCommodityPutViewModel<TEntity> _EmployeeCommodityPutViewModel { get; private set; }
        public EmployeeCommodityDeleteViewModel<TEntity> _EmployeeCommodityDeleteViewModel { get; private set; }
        public EmployeeCommodityGetsViewModel<TEntity> _EmployeeCommodityGetsViewModel { get; private set; }
        public EmployeeCommodityPageViewModel(EmployeeCommodityPostViewModel<TEntity> postViewModel, EmployeeCommodityPutViewModel<TEntity> putViewModel, 
                                EmployeeCommodityDeleteViewModel<TEntity> deleteViewModel, EmployeeCommodityGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployeeCommodityPostViewModel = postViewModel;
            _EmployeeCommodityPutViewModel = putViewModel;  
            _EmployeeCommodityGetsViewModel = getsViewModel;
            _EmployeeCommodityDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployeeCommodityPostViewModel<TEntity> : CommodityPostViewModel<TEntity> where TEntity : EmployeeCommodity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeCommodityPostViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeCommodityPutViewModel<TEntity> : CommodityPutViewModel<TEntity> where TEntity : EmployeeCommodity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeCommodityPutViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeCommodityGetsViewModel<TEntity> : CommodityGetsViewModel<TEntity> where TEntity : EmployeeCommodity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeCommodityGetsViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeCommodityDeleteViewModel<TEntity> : CommodityDeleteViewModel<TEntity> where TEntity : EmployeeCommodity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeCommodityDeleteViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }

    public class EmployeeCenterPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EmployeeCenter, new()
    {
        public EmployeeCenterPostViewModel<TEntity> _EmployeeCenterPostViewModel { get; private set; }
        public EmployeeCenterPutViewModel<TEntity> _EmployeeCenterPutViewModel { get; private set; }
        public EmployeeCenterDeleteViewModel<TEntity> _EmployeeCenterDeleteViewModel { get; private set; }
        public EmployeeCenterGetsViewModel<TEntity> _EmployeeCenterGetsViewModel { get; private set; }
        public EmployeeCenterPageViewModel(EmployeeCenterPostViewModel<TEntity> postViewModel, EmployeeCenterPutViewModel<TEntity> putViewModel, 
                                EmployeeCenterDeleteViewModel<TEntity> deleteViewModel, EmployeeCenterGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployeeCenterPostViewModel = postViewModel;
            _EmployeeCenterPutViewModel = putViewModel;  
            _EmployeeCenterGetsViewModel = getsViewModel;
            _EmployeeCenterDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployeeCenterPostViewModel<TEntity> : CenterPostViewModel<TEntity> where TEntity : EmployeeCenter, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeCenterPostViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeCenterPutViewModel<TEntity> : CenterPutViewModel<TEntity> where TEntity : EmployeeCenter, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeCenterPutViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeCenterGetsViewModel<TEntity> : CenterGetsViewModel<TEntity> where TEntity : EmployeeCenter, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeCenterGetsViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeCenterDeleteViewModel<TEntity> : CenterDeleteViewModel<TEntity> where TEntity : EmployeeCenter, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeCenterDeleteViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}
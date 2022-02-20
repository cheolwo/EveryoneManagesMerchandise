namespace BusinessLogic.ofManager.ofGeneric.ofContract
{
    public class ContractInfo : Entity, IRelationable
    {
        public string Content { get; set; }
        public string CenterAId { get; set; }
        public string CenterBId { get; set; }
    }
    public interface IContractManager<TEntity> : IEntityManager<TEntity> where TEntity : Entity, IRelationable, new()
    {
        public async Task Contract(Center A, Center B, TEntity Entity);
    }
    public class ContractManager<TEntity> : EntityManager<TEntity>, IContractManager<TEntity>
                             where TEntity : ContratInfo, IRelationable, new()
    {
        private readonly IContractRepositroy<TEntity> _contractRepositroy;
        private readonly IContractFileFactory<TEntity> _contractFileFactory;
        private readonly IContractIdFactory<TEntity> _contractIdFactory;
        public ContractManager(IContractRepository<TEntity> contractRepository,
                               IContractFileFactory<TEntity> contractFileFactory,
                               IContractIdFactory<TEntity> contractIdFactory,
                               DicConvertFactory<TEntity> dicConvertFactory)
            : base(contractRepository, contractIdFactory, contractFileFactory, dicConvertFactory)
        {
            _contractRepositroy = contractRepository;
            _contractFileFactory = contractFileFactory;
            _contractIdFactory = contractIdFactory;
        }
    }
    public class HRContractManager<TEntity> : ContractManager<TEntity>
                                        where TEntity : HRInfo, IRelationable, new()
    {

    }

    /*
        1. 계약사항 저장단계 StatusContractManager<TEntity>
        2. 상태 저장단계 StatusManager<TEntity>
        3. 상태에 대한 회계 및 인사처리 단계를 포함하는 Status
                StatusJounalManager<TEntity>, StausHRManager<TEntity>
    2는 1의 Observer로 3은 2의 Observer 로서 처리한다. 
    */
    public class StatusContractManager<TStatus> : ContractManager<TStatus>, IContractManager<TStatus>,
        IObservable<TStatus> where TStatus : Status, IRelatioanble, new()
    {
        private readonly IStatusContractRepositroy<TStatus> _StatusContractRepositroy;
        private readonly IStatusContractFileFactory<TStatus> _StatusContractFileFactory;
        private readonly IStatusContractIdFactory<TStatus> _StatusContractIdFactory;
        private List<IObserver<TStatus>> Observers = new();
        public StatusContractManager(IStatusContractRepository<TStatus> StatusContractRepository,
                               IStatusContractFileFactory<TStatus> StatusContractFileFactory,
                               IStatusContractIdFactory<TStatus> StatusContractIdFactory,
                               DicConvertFactory<TStatus> dicConvertFactory,
                               StatusManager<TStatus> statusManager)
            : base(StatusContractRepository, StatusContractIdFactory, StatusContractFileFactory, dicConvertFactory)
        {
            _StatusContractRepositroy = StatusContractRepository;
            _StatusContractFileFactory = StatusContractFileFactory;
            _StatusContractIdFactory = StatusContractIdFactory;
            Observers.Add(statusManager);
        }
        public async Task Contract(ContractInfo<TStatus> contractInfo)
        {
            
        } 
    }
    public class ContractInfo<TStatus> where TStatus : Status, IRelationable
    {
        public string ACenterId {get; set;}
        public string BCenterId {get; set;}
        public string CommodityId {get; set;}
        public string Info {get; set;}
        public TStatus TStatus {get; set;}
    }
    // Status의 경우 변화의 주체고 계약에 의해 움직이기 때문에 ContractInfo 라는 개체를 상속해도
    // 별 문제가 없을 것 같기는 해. 그런데 Status를 관리할 때 늘 상 ContractInfo를 수반하는 것은
    // 아니기 때문에 상속으로 연결시키기보다 인터페이스로 연결시키는 게 바람직하지 않을까 싶네.
}




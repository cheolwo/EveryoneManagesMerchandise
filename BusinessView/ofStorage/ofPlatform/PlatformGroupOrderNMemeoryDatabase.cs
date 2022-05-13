namespace BusinessView.ofStorage.ofPlatform
{
    public class PlatformGroupOrderNMemoryDatabase : Database
    {
        public PlatformGroupOrderNMemoryDatabase()
        {
            var _PlatformGOCS = this.Tables.Create<PlatformGOCS, string>(x => x.Id, null);
            var _PlatformGOCCS = this.Tables.Create<PlatformGOCCS, string>(x => x.Id, null);
            var _PlatformSGOCS = this.Tables.Create<PlatformSGOCS, string>(x => x.Id, null);
            var _PlatformMGOCS = this.Tables.Create<PlatformMGOCS, string>(x => x.Id, null);
            var _PlatformEGOCS = this.Tables.Create<PlatformEGOCS, string>(x => x.Id, null);

            PlatformGOCS = _PlatformGOCS;
            PlatformGOCCS = _PlatformGOCCS;
            PlatformSGOCS = _PlatformSGOCS;
            PlatformMGOCS = _PlatformMGOCS;
            PlatformEGOCS = _PlatformEGOCS;
        }
        public ITable<PlatformGOC> PlatformGOCS {get; private set;}
        public ITable<PlatformGOCC> PlatformGOCCS {get; private set;}
        public ITable<PlatformSGOC> PlatformSGOCS {get; private set;}
        public ITable<PlatformMGOC> PlatformMGOCS {get; private set;}
        public ITable<PlatformEGOC> PlatformEGOCS {get; private set;}
    }
}
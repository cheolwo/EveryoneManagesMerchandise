using NMemory.Tables;

namespace BusinessView.ofUser.ofCommon
{

    public class StorageBuilder
    {
        private Dictionary<int, ITable> DicTable { get; set; }
        public StorageBuilder()
        {
            DicTable = new();
        }
        // Using // Actor : virtual void OnConfigureTable(TableBuilder TableBuilder)
        public void Add(string nameofDTO, ITable Table)
        {
            DicTable.Add(nameofDTO.GetHashCode(), Table);
        }
        // Using // Actor : virtaul Add<T> (T t) where T : IViewModel
        // This Method Purpose is to Get Table In Dictionay of Tables
        public ITable Get(string nameofDTO)
        {
            return DicTable[nameofDTO.GetHashCode()]
                   ?? throw new ArgumentNullException("Not Include Table For ViewModel");
        }
    }
}

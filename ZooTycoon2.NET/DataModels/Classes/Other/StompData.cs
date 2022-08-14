using ZooTycoon2.NET.DataModels.Interfaces;

namespace ZooTycoon2.NET.DataModels.Classes.Other
{
    public class StompData
    {
        private IEnumerable<Type> _stompTypes { get; set; } = Enumerable.Empty<Type>();
        public IEnumerable<Type> StompTypes
        {
            get => _stompTypes;
            set
            {
                List<Type> stompTypeList = new();
                foreach (Type type in value)
                {
                    if (type.GetInterface(nameof(IType)) != null)
                        stompTypeList.Add(type);
                }
                _stompTypes = stompTypeList;
            }
        }
    }
}

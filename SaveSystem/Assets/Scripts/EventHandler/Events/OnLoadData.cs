using EventHandler.Interfaces;

namespace EventHandler.Events
{
    public readonly struct OnLoadData : IEvent
    {
        public OnLoadData(int saveFileNumber)
        {
            SaveFileNumber = saveFileNumber;
        }

        public int SaveFileNumber { get; }
    }
}

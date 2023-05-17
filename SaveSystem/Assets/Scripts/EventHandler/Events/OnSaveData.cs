using EventHandler.Interfaces;

namespace EventHandler.Events
{
    public readonly struct OnSaveData : IEvent
    {
        public OnSaveData(int saveFileNumber)
        {
            SaveFileNumber = saveFileNumber;
        }

        public int SaveFileNumber { get; }
    }
}

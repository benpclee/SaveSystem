using EventHandler.Interfaces;
using SaveSystem.Views;

namespace EventHandler.Events
{
    public readonly struct OnUpdateData : IEvent
    {
        public OnUpdateData(ISavedView savedView)
        {
            SavedView = savedView;
        }

        public ISavedView SavedView { get; }
    }
}

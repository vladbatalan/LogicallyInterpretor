
namespace LogicalSchemeManager
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(string text);
        void ClearAllObservers();
    }
}

using System.Collections.Generic;

public abstract class Observable
{
    protected List<IObserver> _observers = new();

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    protected void NotifyUpdate()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
} 
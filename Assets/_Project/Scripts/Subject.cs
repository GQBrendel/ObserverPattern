using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    private List<Observer> _observers;

    private void Awake()
    {
        _observers = new List<Observer>();
    }

    public void AddObserver(Observer observer)
    {
        _observers.Add(observer);
    }
    public void RemoveObserver(Observer observer)
    {
        if (!_observers.Contains(observer))
        {
            Debug.LogWarningFormat("Tried to remove {0} from observers list, but {0} is not on the list.", observer);
            return;
        }
        _observers.Remove(observer);
    }

    protected void Notify()
    {
        for (int i = 0; i < _observers.Count; i++)
        {
            _observers[i].OnNotify();
        }
    }
}
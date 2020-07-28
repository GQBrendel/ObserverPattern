using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighestPlatformArea : Subject
{
    [SerializeField] private Observer _observer;

    private void Start()
    {
        AddObserver(_observer);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Notify();
        }
    }

    private void OnDestroy()
    {
        RemoveObserver(_observer);
    }
}

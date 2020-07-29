using UnityEngine;

public class HighestPlatformArea : Subject
{
    [SerializeField] private Observer _observer;

    private void Start()
    {
        AddObserver(_observer);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Notify();
        }
    }

    private void OnDestroy()
    {
        RemoveObserver(_observer);
    }
}
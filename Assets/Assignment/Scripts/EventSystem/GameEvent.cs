using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewGameEvent", menuName = @"events/Game Event", order = 1), Serializable]
public class GameEvent : ScriptableObject
{
    [SerializeField]
    private List<GameEventListener> listeners = new List<GameEventListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
            listeners[i].OnEventRaised();
    }

    public void Raise(double value)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
            listeners[i].OnEventRaised();
    }

    internal void RegisterListener(GameEventListener gameEventListener)
    {
        listeners.Add(gameEventListener);
    }

    internal void UnregisterListener(GameEventListener gameEventListener)
    {
        listeners.Remove(gameEventListener);
    }
}
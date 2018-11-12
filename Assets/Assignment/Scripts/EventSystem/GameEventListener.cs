using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
///  <para>
///  Subscribe to a list of GameEvents. When a GameEvent from this is raised then the listeners responds with 
///  a UnityEvent Response;
/// </para>
/// </summary>
public class GameEventListener : MonoBehaviour
{
    [SerializeField, Tooltip("The Game events this Listener will subscribe to")]
    private List<GameEvent> _gameEvents;
    public UnityEvent Response;

    public List<GameEvent> GameEvents
    {
        get
        {
            return _gameEvents;
        }

        set
        {
            _gameEvents = value;
        }
    }

    private void OnEnable()
    {
        foreach (GameEvent gameEvent in GameEvents)
            gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        foreach (GameEvent gameEvent in GameEvents)
            gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
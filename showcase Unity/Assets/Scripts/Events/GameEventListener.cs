using UnityEngine;
using UnityEngine.Events; // 1

public class GameEventListener : MonoBehaviour
{
    [SerializeField]
    private GameEvent _gameEvent; // 2
    [SerializeField]
    private UnityEvent _response; // 3

    private void OnEnable() // 4
    {
        _gameEvent.RegisterListener(this);
    }

    private void OnDisable() // 5
    {
        _gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised() // 6
    {
        _response.Invoke();
    }
}
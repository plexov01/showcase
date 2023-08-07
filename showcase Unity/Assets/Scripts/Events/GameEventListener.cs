using UnityEngine;
using UnityEngine.Events; // 1

public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameEvent _gameEvent; 
    [SerializeField] private UnityEvent _response; 

    private void OnEnable()
    {
        _gameEvent.RegisterListener(this);
    }

    private void OnDisable() 
    {
        _gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised() 
    {
        _response.Invoke();
    }
}
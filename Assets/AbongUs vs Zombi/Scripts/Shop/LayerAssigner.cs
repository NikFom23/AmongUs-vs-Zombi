using UnityEngine;


public class LayerAssigner : MonoBehaviour
{
    private GameObject[] _buttonActive;

    public GameSession _gameSession;

    private void Start()
    {
        _buttonActive = _gameSession.Data._buttonActive;
        SerchActive();
    }

    private void SerchActive()
    {
       
    }
}
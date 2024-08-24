using UnityEngine;

public class ChoiceActiveButton : MonoBehaviour
{
    [SerializeField] private string _nameGun;

    public GameSession _gameSession;

    public void NameGun()
    {
        _gameSession.Data._nameGun = _nameGun;
    }
}

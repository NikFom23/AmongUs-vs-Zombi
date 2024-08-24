using UnityEngine;

public class ButtonCheck : MonoBehaviour
{
    [SerializeField] private string _nameGun;

    public GameSession _gameSession;

    private void ButtonChoice()
    {
        _nameGun = _gameSession.Data._nameGun;
    }
}

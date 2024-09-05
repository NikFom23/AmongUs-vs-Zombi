using UnityEngine;
using UnityEngine.UI;

public class MenuGuns : MonoBehaviour
{
    [SerializeField] private Sprite[] _images;

    public GameSession _gameSession;

    private Component _sprite;
    private string _name;

    private void Start()
    {
        _sprite = GetComponent<Image>();
        
        _images[0].name = "Pistol";
        _images[1].name = "Small gun";
        _images[2].name = "BigWing";
        _images[3].name = "Calibri";
        _images[4].name = "Fonk";
        _images[5].name = "SVH";

        SearchGuns();

    }

    private void Update()
    {

        SearchGuns();

    }

    private void SearchGuns()
    {
        _name = _gameSession.Data._nameGun;

        foreach (Sprite obj in _images)
        {
            if (obj.name == _name)
            {
                _sprite.GetComponent<Image>().sprite = obj;
                break;
            }
        }
    }

}

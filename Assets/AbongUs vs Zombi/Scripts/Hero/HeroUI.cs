using PixelCrew.Model;
using UnityEngine;
using UnityEngine.UI;

public class HeroUI : MonoBehaviour
{
    [SerializeField] private GameObject _healHero;
    [SerializeField] private Sprite[] _newSprite;


    private Image _imageHeal;
    private float _healsQuantity;


    private void Start()
    {
        _imageHeal = GetComponent<Image>();

       
    } 

    public void HealImageUI()
    {
        _healsQuantity = _healHero.GetComponent<Heals>()._heals;

        if (_healsQuantity == 4)
        {
            _imageHeal.sprite = _newSprite[0];
        }

        if (_healsQuantity == 3)
        {
            _imageHeal.sprite = _newSprite[1];
        }

        if (_healsQuantity == 2)
        {
            _imageHeal.sprite = _newSprite[2];
        }

        if (_healsQuantity == 1)
        {
            _imageHeal.sprite = _newSprite[3];
        }

        if (_healsQuantity == 5)
        {

        }
    }
}

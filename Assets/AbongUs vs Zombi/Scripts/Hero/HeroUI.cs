
using UnityEngine;
using UnityEngine.UI;

public class HeroUI : MonoBehaviour
{
    [SerializeField] private GameObject _healHero;
    [SerializeField] private Sprite[] _newSprite;


    private Image _imageHeal;
    private int _healsQuantity;


    private void Start()
    {
        _imageHeal = GetComponent<Image>();

       
    }

    private void Update()
    {
        HealImageUI();
    }

    public void HealImageUI()
    {
        _healsQuantity = _healHero.GetComponent<Heals>()._heals;

        
        if (_healsQuantity > 0 && _healsQuantity <= _newSprite.Length)
        {
            
            _imageHeal.sprite = _newSprite[_healsQuantity - 1];
        }
    }
}

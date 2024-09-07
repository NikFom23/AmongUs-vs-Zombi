using TMPro;
using UnityEngine;

public class ÑartridgesData : Weapon
{
    [SerializeField] GameSession _gameSession;

    
    private TextMeshProUGUI _textMeshPro;

    public override void Use()
    {
    }

    private void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
        

    }

    private void Update()
    {
        
        _textMeshPro.text = _gameSession.Data._cartridges.ToString();
    }

}

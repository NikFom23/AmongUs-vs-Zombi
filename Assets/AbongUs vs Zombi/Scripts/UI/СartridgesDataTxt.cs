using TMPro;
using UnityEngine;

public class СartridgesDataTxt : MonoBehaviour
{
    [SerializeField] GameSession _gameSession;


    private TMP_Text _textMeshPro;

    

    private void Start()
    {
        _textMeshPro = GetComponent<TMP_Text>();


    }

    private void Update()
    {

        _textMeshPro.text = _gameSession.Data._cartridges.ToString();
    }
}

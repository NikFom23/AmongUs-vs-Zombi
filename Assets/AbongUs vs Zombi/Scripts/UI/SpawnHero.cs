using UnityEngine;

public class SpawnHero : MonoBehaviour
{
    [SerializeField] private GameObject _hero;
    //[HideInInspector] public GameObject _hero;

    private Vector3 _transformSpawn;

    private void Start()
    {
        _transformSpawn = transform.position;
        Instantiate(_hero, _transformSpawn, Quaternion.identity);
    }
}

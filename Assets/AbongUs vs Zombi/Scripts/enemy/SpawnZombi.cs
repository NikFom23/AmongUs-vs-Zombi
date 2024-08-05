using UnityEngine;

public class SpawnZombi : MonoBehaviour
{
    [SerializeField] private GameObject _zombi;

    [SerializeField] private int _enemyQuantity;
    private Collider2D _spawnArea;

    private void Start()
    {
        _spawnArea = GetComponent<Collider2D>();
        SpawnObject();
    }

    private void SpawnObject()
    {
        for (int i = _enemyQuantity; i >= 0; i--)
        {
            Vector3 randomPos = new Vector3(Random.Range(_spawnArea.bounds.min.x, _spawnArea.bounds.max.x),
                                            Random.Range(_spawnArea.bounds.min.y, _spawnArea.bounds.max.y),
                                            Random.Range(_spawnArea.bounds.min.z, _spawnArea.bounds.max.z));
            Instantiate(_zombi, randomPos, Quaternion.identity);
        }
    }
}

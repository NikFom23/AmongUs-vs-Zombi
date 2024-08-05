using UnityEngine;

public class SpawnZombiTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _zombi;

    [SerializeField] private int _enemyQuantity;
    private Collider2D _spawnArea;

    private void Start()
    {
        _spawnArea = GetComponent<Collider2D>();
    }

    public void SpawnZombi()
    {
        Debug.Log("Запущен");

        for (int i = 0; i < _enemyQuantity; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(_spawnArea.bounds.min.x, _spawnArea.bounds.max.x),
                                            Random.Range(_spawnArea.bounds.min.y, _spawnArea.bounds.max.y),
                                            0);
            Instantiate(_zombi, randomPos, Quaternion.identity);
        }
    }
}

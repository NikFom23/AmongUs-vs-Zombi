
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    
        [SerializeField] private GameSession _gameSessionPrefab;

        private void Awake()
        {
            if (FindObjectOfType<GameSession>() == null)
            {
                var gameSession = Instantiate(_gameSessionPrefab);
                DontDestroyOnLoad(gameSession);
            }
        }
    
}

using UnityEngine;


public class GameSession : MonoBehaviour
{
    [SerializeField] private PlayerData _data;
    [SerializeField] private WeaponDataAK _weaponData;

    public PlayerData Data => _data;
    public WeaponDataAK WeaponData => _weaponData;

    private void Awake()
    {
        if (IsSessionExit())
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(this);
        }

    }

    private bool IsSessionExit()
    {
        var sessions = FindObjectsOfType<GameSession>();
        foreach (var gameSession in sessions)
        {
            if (gameSession != this)
            {
                return true;
            }
        }

        return false;
    }

}







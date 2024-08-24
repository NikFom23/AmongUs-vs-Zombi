using UnityEngine;


public class GameSession : MonoBehaviour
{
    [SerializeField] private PlayerData _data;
    [SerializeField] private WeaponDataAK _weaponData;
    [SerializeField] private WeponPistol _weponPistol;
    [SerializeField] private WeaponBigWing _weaponBigWing;
    [SerializeField] private WeaponDataCalibri _weaponCalibri;
    [SerializeField] private WeaponDataFonk _weaponFonk;
    [SerializeField] private WeaponDataSWH _weaponSWH;


    public PlayerData Data => _data;
    public WeaponDataAK WeaponData => _weaponData;
    public WeponPistol WeponPistol => _weponPistol;
    public WeaponBigWing WeaponBigWing => _weaponBigWing;
    public WeaponDataCalibri DataCalibri => _weaponCalibri;
    public WeaponDataFonk DataFonk => _weaponFonk;
    public WeaponDataSWH DataSWH => _weaponSWH;
    


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







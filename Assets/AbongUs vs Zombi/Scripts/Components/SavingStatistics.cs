using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingStatistics : MonoBehaviour
{
    public WeponCharacteristics[] _weaponCharacteristics;

    public GameSession _gameSession;

    private void Start()
    {
        _weaponCharacteristics = new WeponCharacteristics[]
        {
            new WeponPistol(),
            new WeaponDataAK(),
            new WeaponBigWing(),
            new WeaponDataCalibri(),
            new WeaponDataFonk(),
            new WeaponDataSWH()
        };

    }

    public void SaveData()
    {
        if (_gameSession != null && _gameSession.Data != null)
        {
            foreach (var weapon in _weaponCharacteristics)
            {
                

                if (weapon._name == _gameSession.Data._gunObj.name)
                {
                    
                    weapon._cartridges = _gameSession.Data._cartridges;
                    
                    break;
                }
            }
        }
    }
}

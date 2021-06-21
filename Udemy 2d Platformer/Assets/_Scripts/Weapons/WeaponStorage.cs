using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStorage : MonoBehaviour
{
    public int WeaponCount { get; internal set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal WeaponData GetCurrentWeapon()
    {
        throw new NotImplementedException();
    }

    internal WeaponData SwapWeapon()
    {
        throw new NotImplementedException();
    }

    internal void AddWeaponData(WeaponData weaponData)
    {
        throw new NotImplementedException();
    }

    internal List<string> GetPlayerWeaponNames()
    {
        throw new NotImplementedException();
    }
}

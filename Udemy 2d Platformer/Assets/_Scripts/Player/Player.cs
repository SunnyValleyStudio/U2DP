using SVS.Levels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponSystem;

namespace SVS.PlayerAgent
{
    public class Player : MonoBehaviour, ISaveData
    {
        private WeaponsManager weaponManager;
        [SerializeField]
        private AgentWeaponManager playerWeapons;

        private void Awake()
        {
            weaponManager = FindObjectOfType<WeaponsManager>();
        }

        public void LoadData()
        {
            List<string> weaponNames = SaveSystem.LoadWeapons();
            if (weaponNames != null)
            {
                foreach (string name in weaponNames)
                {
                    Debug.Log("Loading weapon: " + name);
                    WeaponData weapon = weaponManager.GetWeaponWithName(name);
                    playerWeapons.AddWeaponData(weapon);
                }
            }
            else
            {
                Debug.Log("No weapon data to load");
            }
        }

        public void SaveData()
        {
            List<string> weaponNames = playerWeapons.GetPlayerWeaponNames();
            if (weaponNames != null && weaponNames.Count > 0)
                SaveSystem.SaveWeapons(weaponNames);
        }
    }
}
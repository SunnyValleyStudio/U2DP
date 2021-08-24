using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponSystem;

namespace SVS.PlayerAgent
{
    public class WeaponsManager : MonoBehaviour
    {
        public List<WeaponData> weaponList;
        Dictionary<string, WeaponData> weaponDictionary = new Dictionary<string, WeaponData>();

        private void Awake()
        {
            AddToDictionary(weaponList);
        }

        private void AddToDictionary(List<WeaponData> weaponList)
        {
            foreach (WeaponData item in weaponList)
            {
                if (weaponDictionary.ContainsKey(item.name))
                    continue;
                weaponDictionary.Add(item.name, item);
            }
        }

        public WeaponData GetWeaponWithName(string name)
        {
            if (weaponDictionary.ContainsKey(name))
                return weaponDictionary[name];
            return null;
        }
    }
}
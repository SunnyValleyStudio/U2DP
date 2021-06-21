using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeaponSystem
{
    public class GiveAgentAWeapon : MonoBehaviour
    {
        public List<WeaponData> weaponData = new List<WeaponData>();

        void Start()
        {
            Agent agent = GetComponentInChildren<Agent>();
            if (agent == null)
                return;
            foreach (var item in weaponData)
            {
                agent.agentWeapon.AddWeaponData(item);
            }
        }


    }
}
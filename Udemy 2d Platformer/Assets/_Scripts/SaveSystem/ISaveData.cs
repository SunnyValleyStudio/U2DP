using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.Levels
{
    public interface ISaveData
    {
        void SaveData();
        void LoadData();
    }
}
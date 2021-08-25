using SVS.Levels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.UI
{
    public class InGameMenuUI : MonoBehaviour
    {
        LevelManagement levelManager;

        private void Awake()
        {
            levelManager = FindObjectOfType<LevelManagement>();
            if (levelManager == null)
                Debug.LogError("No Level Manager found");
        }

        public void LoadMenu()
        {
            levelManager.LoadMenu();
        }

        public void RestartLevel()
        {
            levelManager.RestartCurrentLevel();
        }
    }
}
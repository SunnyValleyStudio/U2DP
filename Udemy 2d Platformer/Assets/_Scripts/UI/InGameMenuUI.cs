using SVS.Levels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.UI
{
    public class InGameMenuUI : MonoBehaviour
    {
        LevelManagement levelManager;
        public GameObject menuPanel;

        private void Awake()
        {
            levelManager = FindObjectOfType<LevelManagement>();
            if (levelManager == null)
                Debug.LogError("No Level Manager found");
        }

        public void ToggleMenu()
        {
            menuPanel.SetActive(!menuPanel.activeSelf);
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        }

        public void LoadMenu()
        {
            levelManager.LoadMenu();
        }

        public void RestartLevel()
        {
            levelManager.RestartCurrentLevel();
        }

        public void ResetTimeScale()
        {
            Time.timeScale = 1;
        }
    }
}
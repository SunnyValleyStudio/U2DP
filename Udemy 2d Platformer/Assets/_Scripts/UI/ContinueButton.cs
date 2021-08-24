using SVS.Levels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SVS.UI
{
    public class ContinueButton : MonoBehaviour
    {
        public LevelManagement sceneManagement;
        public Button continueButton;

        private int levelIndex = -1;

        public UnityEvent OnLevelLoaded;

        private void Awake()
        {
            if (sceneManagement == null)
                sceneManagement = FindObjectOfType<LevelManagement>();
            continueButton = GetComponent<Button>();
        }

        private void Start()
        {
            levelIndex = SaveSystem.LoadLevelIndex();
            if (levelIndex > -1)
            {
                continueButton.onClick.AddListener(() => sceneManagement.LoadSceneWithIndex(levelIndex));
                continueButton.interactable = true;
                OnLevelLoaded?.Invoke();
            }
        }
    }
}
using RespawnSystem;
using SVS.Camera;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace SVS.Levels
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private CameraManager cameraManager;
        [SerializeField]
        private RespawnPointManager spawnPointManager;
        [SerializeField]
        private Agent player;
        private LevelManagement sceneManagement;

        private void Awake()
        {
            if (cameraManager == null)
                cameraManager = FindObjectOfType<CameraManager>();
            if (spawnPointManager == null)
                spawnPointManager = FindObjectOfType<RespawnPointManager>();
            if (player == null)
                player = FindObjectOfType<PlayerInput>().GetComponentInChildren<Agent>();
            sceneManagement = FindObjectOfType<LevelManagement>();
        }

        private void Start()
        {
            LoadData();
            player.gameObject.SetActive(false);
            spawnPointManager.Respawn(player.gameObject);
            cameraManager.SetCameraTarget(player.transform);
        }

        private void LoadData()
        {
            IEnumerable<ISaveData> saveDataScripts = FindObjectsOfType<MonoBehaviour>().OfType<ISaveData>();
            foreach (ISaveData item in saveDataScripts)
            {
                item.LoadData();
            }
        }

        public void SaveGameData()
        {
            IEnumerable<ISaveData> saveDataScripts = FindObjectsOfType<MonoBehaviour>().OfType<ISaveData>();
            foreach (ISaveData item in saveDataScripts)
            {
                item.SaveData();
            }
            SaveSystem.SaveGameData(sceneManagement.GetNextLevelIndex());
        }
    }
}
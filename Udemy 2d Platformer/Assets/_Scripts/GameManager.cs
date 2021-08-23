using RespawnSystem;
using SVS.Camera;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            player.gameObject.SetActive(false);
            spawnPointManager.Respawn(player.gameObject);
            cameraManager.SetCameraTarget(player.transform);
        }
    }
}
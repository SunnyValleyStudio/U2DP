using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

namespace SVS.Camera
{
    public class CameraManager : MonoBehaviour
    {
        public CinemachineVirtualCamera cm_camera;

        private void Awake()
        {
            if (cm_camera == null)
                cm_camera = FindObjectOfType<CinemachineVirtualCamera>();
        }

        public void SetCameraTarget(Transform transform)
        {
            cm_camera.LookAt = transform;
            cm_camera.Follow = transform;
        }
    }
}
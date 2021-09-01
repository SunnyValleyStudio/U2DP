using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

namespace SVS.Camera
{
    public class CmCameraConfinerUtil : MonoBehaviour
    {
        public PolygonCollider2D cameraConfiner;
        public CinemachineConfiner cm_confiner;

        public void SetConfiner()
        {
            cm_confiner.m_BoundingShape2D = cameraConfiner;
        }
    }
}
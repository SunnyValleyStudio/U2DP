using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.Common
{
    public class DestroyUtil : MonoBehaviour
    {
        public void DestroySelf()
        {
            DestroyObject(gameObject);
        }
        public void DestroyObject(GameObject objectToDestroy)
        {
            Destroy(objectToDestroy);
        }
    }
}
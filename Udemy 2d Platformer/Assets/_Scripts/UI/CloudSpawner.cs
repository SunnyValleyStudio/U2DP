using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.UI
{
    public class CloudSpawner : MonoBehaviour
    {
        [SerializeField]
        private float width = 10, length = 10;
        [SerializeField]
        private Color gizmoColor = new Color(1, 0, 0, 0.2f);
        [SerializeField]
        private bool showGizmo = true;
        [SerializeField]
        private List<Cloud> cloudPrefabs = new List<Cloud>();
        private RectTransform myRectTransform;
        public RectTransform fronCloudParent;

        private void Awake()
        {
            myRectTransform = GetComponent<RectTransform>();
        }

        private void Start()
        {
            foreach (Transform item in myRectTransform)
            {
                item.GetComponent<Cloud>().Initialize(width / 2 + 50, SpawnClouds);
            }
            foreach (Transform item in fronCloudParent)
            {
                item.GetComponent<Cloud>().Initialize(width / 2 + 50, SpawnClouds);
            }
        }

        public void SpawnClouds()
        {
            Vector3 position = GetRandomPosition();
            Transform parent = myRectTransform;

            int cloudIndex = Random.Range(0, cloudPrefabs.Count);
            Cloud cloud = cloudPrefabs[cloudIndex];

            float scale = cloud.GetCloudScale();

            GameObject cloudObject = Instantiate(cloud.gameObject);

            RectTransform rectTransform = cloudObject.GetComponent<RectTransform>();

            rectTransform.position = position;

            

            Cloud newCloud = cloudObject.GetComponent<Cloud>();

            newCloud.speed = 50;
            if (Random.value > 0.5)
            {
                parent = fronCloudParent;
                newCloud.speed = 70;
                scale += 0.5f;
            }

            rectTransform.SetParent(parent);

            rectTransform.localScale = Vector3.one * scale;

            newCloud.Initialize(width / 2 + 50, SpawnClouds);

        }

        private Vector3 GetRandomPosition()
        {
            return new Vector3(
                myRectTransform.position.x - width / 2 + Random.Range(0, 50), 
                Random.Range(myRectTransform.transform.position.y - length / 2, myRectTransform.transform.position.y + length / 2), 
                1);
        }

        private void OnDrawGizmos()
        {
            if (showGizmo)
            {
                Gizmos.color = gizmoColor;
                RectTransform rectTransform = GetComponent<RectTransform>();
                Gizmos.DrawCube(rectTransform.position, new Vector2(width, length));

            }

        }
    }
}
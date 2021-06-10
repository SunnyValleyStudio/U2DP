using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RespawnSystem
{
    public class RespawnPoint : MonoBehaviour
    {
        [SerializeField]
        private GameObject respawnTarget;

        [field: SerializeField]
        private UnityEvent OnSpawnPointActivated { get; set; }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                this.respawnTarget = collision.gameObject;
                OnSpawnPointActivated?.Invoke();
                GetComponent<Collider2D>().enabled = false;
            }
        }

        public void RespawnPlayer()
        {
            respawnTarget.transform.position = transform.position;
        }

        public void SetPlayerGO(GameObject player)
        {
            respawnTarget = player;
            GetComponent<Collider2D>().enabled = false;
        }

        public void DisableRespawnPoint()
        {
            gameObject.SetActive(false);
        }

        public void ResetRespawnPoint()
        {
            respawnTarget = null;
            GetComponent<Collider2D>().enabled = true;
        }
    }
}



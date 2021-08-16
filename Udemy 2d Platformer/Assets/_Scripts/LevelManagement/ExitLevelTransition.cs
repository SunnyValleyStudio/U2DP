using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SVS.Levels
{
    public class ExitLevelTransition : MonoBehaviour
    {
        [SerializeField]
        private string playerTag = "Player";
        [SerializeField]
        private string inputAxisName = "Vertical";
        [SerializeField]
        private int inputAxisValue = 1;

        private bool playerInRange = false;

        public UnityEvent OnPlayerEnter, OnPlayerExit, OnTransition;

        private void Update()
        {
            if (playerInRange)
            {
                if ((int)Input.GetAxisRaw(inputAxisName) >= inputAxisValue)
                {
                    OnTransition?.Invoke();
                }
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(playerTag))
            {
                playerInRange = true;
                OnPlayerEnter?.Invoke();

            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag(playerTag))
            {
                OnPlayerExit?.Invoke();
            }
        }
    }
}
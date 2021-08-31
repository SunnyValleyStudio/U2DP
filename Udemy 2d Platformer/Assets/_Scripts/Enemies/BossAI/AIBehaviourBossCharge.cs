using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.AI
{
    public class AIBehaviourBossCharge : AIBehaviour
    {
        [SerializeField]
        private AIDataBoard aiBoard;
        [SerializeField]
        private AiPlayerEnterAreaDetector playerDetector;
        [SerializeField]
        private Agent agent;

        private Vector3 tempPosition;
        private Vector2 direction;

        private bool initialized = false;

        public override void PerformAction(AIEnemy enemyAI)
        {
            if (aiBoard.CheckBoard(AIDataTypes.Arrived))
                initialized = false;

            SetChargeDestination();

            ChargeAtThePlayer(enemyAI);

            if (aiBoard.CheckBoard(AIDataTypes.PathBlocked))
            {
                enemyAI.CallOnMovement(Vector2.zero);
                enemyAI.MovementVector = Vector2.zero;
                aiBoard.SetBoard(AIDataTypes.Waiting, true);
                aiBoard.SetBoard(AIDataTypes.Arrived, true);
            }
        }

        private void ChargeAtThePlayer(AIEnemy enemyAI)
        {
            enemyAI.CallOnMovement(direction.normalized);
            enemyAI.MovementVector = direction.normalized;
        }

        private void SetChargeDestination()
        {
            if (initialized)
                return;

            tempPosition = new Vector2(playerDetector.Player.position.x, agent.transform.position.y);
            direction = tempPosition - agent.transform.position;
            aiBoard.SetBoard(AIDataTypes.Arrived, false);
            initialized = true;
        }
    }
}
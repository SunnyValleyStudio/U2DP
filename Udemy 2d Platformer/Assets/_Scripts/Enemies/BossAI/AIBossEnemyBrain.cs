using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.AI
{
    public class AIBossEnemyBrain : AIEnemy
    {
        [SerializeField]
        private AIDataBoard aiBoard;
        [SerializeField]
        private AiPlayerEnterAreaDetector playerDetector;
        [SerializeField]
        private AIMeleeAttackDetector meleeRangeDetector;
        [SerializeField]
        private AIEndPlatformDetector endPlatformDetector;

        [SerializeField]
        private AIBehaviour IdleBehaviour, ChargeBehaviour, MeleeAttackBehaviour, WaitBehaviour;

        private void Update()
        {
            aiBoard.SetBoard(AIDataTypes.PlayerDetected, playerDetector.PlayerInArea);
            aiBoard.SetBoard(AIDataTypes.InMeleeRange, meleeRangeDetector.PlayerDetected);
            aiBoard.SetBoard(AIDataTypes.PathBlocked, endPlatformDetector.PathBlocked);

            if (aiBoard.CheckBoard(AIDataTypes.PlayerDetected))
            {
                if (aiBoard.CheckBoard(AIDataTypes.Waiting))
                {
                    WaitBehaviour.PerformAction(this);
                }
                else
                {
                    if (aiBoard.CheckBoard(AIDataTypes.InMeleeRange))
                    {
                        MeleeAttackBehaviour.PerformAction(this);
                    }
                    else
                    {
                        ChargeBehaviour.PerformAction(this);
                    }
                }
            }
            else
            {
                IdleBehaviour.PerformAction(this);
            }
        }
    }
}
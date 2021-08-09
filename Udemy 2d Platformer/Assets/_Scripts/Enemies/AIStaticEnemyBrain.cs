using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.AI
{
    public class AIStaticEnemyBrain : AIEnemy
    {
        public AIBehaviour AttackBehaviour;

        private void Update()
        {
            AttackBehaviour.PerformAction(this);
        }
    }
}
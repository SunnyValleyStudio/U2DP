using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.AI
{
    public abstract class AIBehaviour : MonoBehaviour
    {
        public abstract void PerformAction(AIEnemy enemyAI);
    }
}
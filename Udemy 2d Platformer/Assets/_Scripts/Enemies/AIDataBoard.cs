using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.AI
{
    public class AIDataBoard : MonoBehaviour
    {
        public List<AIDataTypes> dataTypes;

        Dictionary<AIDataTypes, bool> aiBoard = new Dictionary<AIDataTypes, bool>();
        private void Start()
        {
            HashSet<AIDataTypes> noDuplicates = new HashSet<AIDataTypes>(dataTypes);
            foreach (var item in noDuplicates)
            {
                aiBoard.Add(item, false);
            }
        }

        public bool CheckBoard(AIDataTypes aiDataType)
        {
            if (CheckParameter(aiDataType) == false)
                throw new System.Exception("No " + aiDataType.ToString() + " in the AI board for " + gameObject.name);
            return aiBoard[aiDataType];
        }

        public void SetBoard(AIDataTypes aiDataType, bool val)
        {
            if (CheckParameter(aiDataType) == false)
                throw new System.Exception("No " + aiDataType.ToString() + " in the AI board for " + gameObject.name);
            aiBoard[aiDataType] = val;
        }

        public bool CheckParameter(AIDataTypes aiDataType)
        {
            return aiBoard.ContainsKey(aiDataType);
        }
    }

    public enum AIDataTypes
    {
        Waiting,
        PlayerDetected,
        Arrived,
        InMeleeRange,
        PathBlocked
    }
}
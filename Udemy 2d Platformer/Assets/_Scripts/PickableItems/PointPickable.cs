using SVS.PlayerAgent;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SVS.Pickable
{
    public class PointPickable : Pickable
    {
        public UnityEvent OnPickUp;
        [SerializeField]
        private int pointsToAdd = 1;

        public override void PickUp(Agent agent)
        {
            PlayerPoints playerPoints = agent.GetComponent<PlayerPoints>();
            playerPoints.Add(pointsToAdd);
        }
    }
}
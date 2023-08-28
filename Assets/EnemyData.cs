using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : ICharacter
{
    public AIDestinationSetter destination;

    public override void Setup()
    {
        base.Setup();
        // Set speed
        // Set Acceleration
        destination.target = PlayerController.Instance.transform;
    }
    private void Update()
    {
        this.GetComponent<AIPath>().enabled = PlayerController.Instance.isStart;
    }
}

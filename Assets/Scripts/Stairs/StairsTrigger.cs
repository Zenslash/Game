using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsTrigger : MonoBehaviour
{
    [SerializeField] private GameObject targetPosition;
    private PlayerStatsManager playerStatsManager;
    
    public void OnTriggerEnter(Collider other)
    {
        playerStatsManager = other.GetComponentInParent<PlayerStatsManager>();
    }

    private void OnTriggerStay(Collider other)
    {
        playerStatsManager.Movements.MoveToStairs(targetPosition.transform.position);
    }


}

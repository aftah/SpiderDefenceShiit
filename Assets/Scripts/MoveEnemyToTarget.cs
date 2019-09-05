using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MoveEnemyToTarget : MonoBehaviour
{
    

    private Transform gate;
 
    private NavMeshAgent agent;


    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
            
    }
    private void Start()
    {

        gate = Data.instanceData.listGatePosition[Random.Range(0, Data.instanceData.listGatePosition.Count - 1)];
        agent.SetDestination(gate.position);

    }

    private void FixedUpdate()
    {
       

    }

}

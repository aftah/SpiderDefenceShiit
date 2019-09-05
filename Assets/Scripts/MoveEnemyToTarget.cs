using UnityEngine;
using UnityEngine.AI;


public class MoveEnemyToTarget : MonoBehaviour
{
    

    public Transform gate;
 
    private NavMeshAgent agent;


    private void Awake()
    {
        
            
    }
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
       
        agent.SetDestination(gate.position);

    }

   

}

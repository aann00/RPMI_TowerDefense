using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent agente;
    public Vector3 posicion;


    // Start is called before the first frame update
    void Start()
    {
        agente.SetDestination(posicion);
    }

    
}

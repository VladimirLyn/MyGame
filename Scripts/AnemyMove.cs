using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class AnemyMove : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("PlayerWarior").transform;
        if(player == null)
        {
            player = GameObject.Find("PlayerMage").transform;
        }
    }

    private void FixedUpdate()
    {

        agent.destination = player.position;
    }
}

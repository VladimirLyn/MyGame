using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class AnemyMove : MonoBehaviour
{
    Transform player;
    public NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Find());
    }

    private void FixedUpdate()
    {
        agent.destination = player.position;
    }
    public IEnumerator Find()
    {
        while (player == null)
        {
            try
            {
                player = GameObject.Find("PlayerMage(Clone)").transform;
            }
            catch
            {

            }
            try
            {
                player = GameObject.Find("PlayerWarior(Clone)").transform;
            }
            catch
            {
              
            }
            yield return new WaitForSeconds(1);
        }
           
      
    }
}

using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform playerTr;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerTr = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        agent.SetDestination(playerTr.position);
    }
}

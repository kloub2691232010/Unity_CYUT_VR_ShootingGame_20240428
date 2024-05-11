using UnityEngine;
using UnityEngine.AI;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("玩家")]
    private Transform playerPoint;
    [SerializeField, Header("導覽代理器")]
    private NavMeshAgent agent;

    private void Update()
    {
        agent.SetDestination(playerPoint.position);
    }
}

using UnityEngine;
using UnityEngine.AI;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("���a")]
    private Transform playerPoint;
    [SerializeField, Header("�����N�z��")]
    private NavMeshAgent agent;

    private void Update()
    {
        agent.SetDestination(playerPoint.position);
    }
}

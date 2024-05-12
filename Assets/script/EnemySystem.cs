using UnityEngine;
using UnityEngine.AI;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("���a")]
    private Transform playerPoint;
    [SerializeField, Header("�����N�z��")]
    private NavMeshAgent agent;
    [SerializeField, Header("�ʵe���")]
    private Animator ani;

    private string parMove = "���ʼƭ�";
    private string parAttack = "Ĳ�o����";
    private bool isAttacking;

    private void Update()
    {
        move();
        Attack();
    }

    private void move()
    {
        agent.SetDestination(playerPoint.position);

        ani.SetFloat(parMove, agent.velocity.magnitude / agent.speed);
    }

    private void Attack()

    {
        if (isAttacking) return;

        // print($"<color=#6f9>�Z�� : {agent.remainingDistance}</color>");

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            ani.SetTrigger(parAttack);
            isAttacking = true;
        }
    }
}

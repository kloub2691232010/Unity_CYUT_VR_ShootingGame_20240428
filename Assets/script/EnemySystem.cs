using UnityEngine;
using UnityEngine.AI;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("玩家")]
    private Transform playerPoint;
    [SerializeField, Header("導覽代理器")]
    private NavMeshAgent agent;
    [SerializeField, Header("動畫控制器")]
    private Animator ani;

    private string parMove = "移動數值";
    private string parAttack = "觸發攻擊";
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

        // print($"<color=#6f9>距離 : {agent.remainingDistance}</color>");

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            ani.SetTrigger(parAttack);
            isAttacking = true;
        }
    }
}

using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("玩家")]
    private Transform playerPoint;
    [SerializeField, Header("導覽代理器")]
    private NavMeshAgent agent;
    [SerializeField, Header("動畫控制器")]
    private Animator ani;
    [SerializeField, Header("敵人攻擊區域")]
    private GameObject attackArea;

    private string parMove = "移動數值";
    private string parAttack = "觸發攻擊";
    private bool isAttacking;

    private void Awake()
    {
        move();
    }

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
            StartCoroutine(StartAttack());
        }
    }

    private IEnumerator StartAttack()
    {
        print("攻擊開始");
        yield return new WaitForSeconds(0.55f);
        print("前搖結束，對你玩家造成傷害");
        attackArea.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        print("後搖結束");
        attackArea.SetActive(false);
        isAttacking = false;
    }
}

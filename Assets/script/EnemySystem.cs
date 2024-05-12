using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("���a")]
    private Transform playerPoint;
    [SerializeField, Header("�����N�z��")]
    private NavMeshAgent agent;
    [SerializeField, Header("�ʵe���")]
    private Animator ani;
    [SerializeField, Header("�ĤH�����ϰ�")]
    private GameObject attackArea;

    private string parMove = "���ʼƭ�";
    private string parAttack = "Ĳ�o����";
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

        // print($"<color=#6f9>�Z�� : {agent.remainingDistance}</color>");

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            ani.SetTrigger(parAttack);
            isAttacking = true;
            StartCoroutine(StartAttack());
        }
    }

    private IEnumerator StartAttack()
    {
        print("�����}�l");
        yield return new WaitForSeconds(0.55f);
        print("�e�n�����A��A���a�y���ˮ`");
        attackArea.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        print("��n����");
        attackArea.SetActive(false);
        isAttacking = false;
    }
}

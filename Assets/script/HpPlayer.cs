using UnityEngine;

public class HpPlayer : Hpsystem
{
    private string enemyAttackArea = "�ĤH����";

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains(enemyAttackArea))
        {
            Damage(50);
        }
    }
}

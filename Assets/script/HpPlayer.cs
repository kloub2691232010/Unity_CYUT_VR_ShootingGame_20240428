using UnityEngine;

public class HpPlayer : Hpsystem
{
    private string enemyAttackArea = "¼Ä¤H§ðÀ»";

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains(enemyAttackArea))
        {
            Damage(50);
        }
    }
}

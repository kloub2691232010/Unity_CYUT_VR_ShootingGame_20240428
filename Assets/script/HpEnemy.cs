using UnityEngine;

public class HpEnemy : Hpsystem
{
    private string bulletName = "¤l¼u";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains(bulletName))
        {
            float attack = collision.gameObject.GetComponent<Bullet>().attack;
            Damage(attack);
        }
    }
    protected override void Dead()
    {
        base.Dead();


        Destroy(gameObject);

    }
}

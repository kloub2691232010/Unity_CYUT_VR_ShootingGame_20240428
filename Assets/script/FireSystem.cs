using UnityEngine;

public class FireSystem : MonoBehaviour
{
    [SerializeField, Header("�l�u�w�s��")]
    private GameObject prefabBullet;
    [SerializeField, Header("�l�u�����I")]
    private Transform firePoint;
    [SerializeField, Header("�o�g�t��"), Range(0, 3000)]
    private float fireSpeed = 500;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) FireBullet();
    }
    private void FireBullet()
    {
        GameObject temp = Instantiate(prefabBullet, firePoint.position, Quaternion.identity);

        temp.GetComponent<Rigidbody>().AddForce(transform.forward * -fireSpeed);
    }
}


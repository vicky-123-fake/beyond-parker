using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileaddon : MonoBehaviour
{
    public int damage;

    private Rigidbody rb;

    private bool targetHit;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 确保专注于第一个目标
        if (targetHit)
            return;
        else
            targetHit = true;

        // 检查是否击中敌人
        if (collision.gameObject.GetComponent<BasicEnemy>() != null)
        {
            BasicEnemy enemy = collision.gameObject.GetComponent<BasicEnemy>();

            enemy.TakeDamage(damage);

            // 摧毁
            Destroy(gameObject);
        }

        // 确保发射物能附着在物体表面
        rb.isKinematic = true;

        // 确保随目标移动
        transform.SetParent(collision.transform);
    }
}

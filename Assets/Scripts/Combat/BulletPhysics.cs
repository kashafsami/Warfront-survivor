using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    public float bulletSpeed = 15f;
    public int damage = 25;

    void Start()
    {
        // 2D forward force for bullet velocity
        GetComponent<Rigidbody2D>().velocity = transform.right * bulletSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if bullet hits an enemy target
        if (collision.CompareTag("Enemy"))
        {
            // Enemy health reduction logic will handle here
            Destroy(gameObject); // Destroy bullet on impact
        }
    }
}

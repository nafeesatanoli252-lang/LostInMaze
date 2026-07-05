using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    [Header("Attack Settings")]
    public int damage = 20;
    public float attackRate = 1f;

    private float nextAttackTime = 0f;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Time.time >= nextAttackTime)
            {
                PlayerHealth health = other.GetComponent<PlayerHealth>();

                if (health != null)
                {
                    health.TakeDamage(damage);
                    Debug.Log("Zombie Attacked Player!");
                }

                nextAttackTime = Time.time + attackRate;
            }
        }
    }
}
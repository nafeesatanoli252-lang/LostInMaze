using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 2f;
    public float stoppingDistance = 1.5f;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                player.position,
                moveSpeed * Time.deltaTime
            );

            transform.LookAt(player);
        }
    }
}
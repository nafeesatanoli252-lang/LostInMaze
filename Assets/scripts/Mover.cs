using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 2f;
    public float stoppingDistance = 1.5f;

    private Animator animator;

    void Start()
    {
        Debug.Log("Start Running");
        animator = GetComponentInChildren<Animator>();

        if (animator == null)
        {
            Debug.Log("Animator NOT Found");
        }
        else
        {
            Debug.Log("Animator Found");
        }
    }

    void Update()
    {
        Debug.Log("ZombieAI Running");
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

            animator.SetFloat("Speed", 1f);
        }
        else
        {
            animator.SetFloat("Speed", 0f);
        }
    }
}
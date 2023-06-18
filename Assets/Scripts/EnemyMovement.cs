using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player; 
    public float detectionRange = 5f; 
    public float enemyMoveSpeed = 3f; 

    private bool isPlayerDetected = false;

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange)
        {
            isPlayerDetected = true;
            MoveTowardsPlayer();
        }
        else
        {
            isPlayerDetected = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }

    private void MoveTowardsPlayer()
    {
        if (isPlayerDetected)
        {
            Vector3 direction = player.position - transform.position;
            transform.Translate(direction.normalized * enemyMoveSpeed * Time.deltaTime);
        }
    }
}

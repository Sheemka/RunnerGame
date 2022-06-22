using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    private Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayer;

    public float attackRange = 1.7f;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void AttackPlayAnimation()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyKilled>().EnemyKill();
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

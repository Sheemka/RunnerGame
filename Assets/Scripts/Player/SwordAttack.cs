using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    private Animator animator;
    private float vampiricAmmount = 5;
    private float attackRange = 1.7f;

    public LayerMask enemyLayer;
    public Transform attackPoint;
    public PlayerHPSP playerStats;
    public Combo combo;
    
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
            playerStats.TakeHP(vampiricAmmount);
            combo.IncreaseCombo();
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

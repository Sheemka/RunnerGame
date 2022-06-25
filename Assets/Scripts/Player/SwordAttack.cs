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

        //создаю массив на основе того, сколько противников попало в область удара ->
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);
        
        //чтобы здесь каждому врагу нанести урон, за каждого врага получить хп от вампирика и повысить счетчик комбо
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyKilled>().EnemyKill();
            playerStats.TakeHP(vampiricAmmount);
            combo.IncreaseCombo();
        }
    }

    //функция для рисования окружности вокруг пустышки на мече (в этой области наносится урон)
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

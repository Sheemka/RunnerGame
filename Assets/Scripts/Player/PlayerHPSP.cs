using UnityEngine;
using UnityEngine.UI;

public class PlayerHPSP : MonoBehaviour
{
    [SerializeField] public float currentHP;
    [SerializeField] public float currentSP;

    private float _maxHP = 100f;
    private float _maxSP = 100f;
    private float chipSpeed = 2f;
    private float lerpTimer;
    private float staminaGrow = 10;
    private float enemyDamage = 20f;
    private float immortalityTimer;

    public Image frontHPBar;
    public Image backHPBar;
    public Image frontSPBar;
    public Image backSPBar;

    public SwordAttack swordAttack;
    public GameOver gameOver;
    public Combo combo;

    private void Start()
    {
        currentHP = _maxHP;
        currentSP = _maxSP;
    }

    private void Update()
    {
        currentHP = Mathf.Clamp(currentHP, 0, _maxHP);
        if (currentSP < _maxSP)
        {
            currentSP += Time.deltaTime * staminaGrow;
        }

        UpdateSP();
        UpdateHP();

        if (immortalityTimer > 0)
        {
            immortalityTimer -= Time.deltaTime / 2;
        }

        if (currentHP > _maxHP)
        {
            currentHP = _maxHP;
        }
    }

    private void UpdateHP()
    {
        float fillF = frontHPBar.fillAmount;
        float fillB = backHPBar.fillAmount;
        float HFraction = currentHP / _maxHP;

        if (fillB > HFraction)
        {
            frontHPBar.fillAmount = HFraction;
            backHPBar.color = Color.red;
            lerpTimer += Time.deltaTime;

            float percentComplete = lerpTimer / chipSpeed;
            percentComplete *= percentComplete;
            backHPBar.fillAmount = Mathf.Lerp(fillB, HFraction, percentComplete);
        }

        if (fillF < HFraction)
        {
            backHPBar.fillAmount = HFraction;
            backHPBar.color = Color.green;
            lerpTimer += Time.deltaTime;

            float percentComplete = lerpTimer / chipSpeed;
            percentComplete *= percentComplete;
            frontHPBar.fillAmount = Mathf.Lerp(fillF, backHPBar.fillAmount, percentComplete);
        }
    }

    private void UpdateSP()
    {
        float fillF = frontSPBar.fillAmount;
        float fillB = backSPBar.fillAmount;
        float HFraction = currentSP / _maxSP;

        if (fillB > HFraction)
        {
            frontSPBar.fillAmount = HFraction;
            backSPBar.color = new Color (1.0f, 0.64f, 0.0f);
            lerpTimer += Time.deltaTime;

            float percentComplete = lerpTimer / chipSpeed;
            percentComplete *= percentComplete;
            backSPBar.fillAmount = Mathf.Lerp(fillB, HFraction, percentComplete);
        }

        if (fillF < HFraction)
        {
            backSPBar.fillAmount = HFraction;
            backSPBar.color = Color.blue;
            lerpTimer += Time.deltaTime;

            float percentComplete = lerpTimer / chipSpeed;
            percentComplete *= percentComplete;
            frontSPBar.fillAmount = Mathf.Lerp(fillF, backSPBar.fillAmount, percentComplete);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(enemyDamage);
        }
    }  

    public void TakeDamage(float damage)
    {
        if (immortalityTimer <= 0)
        {
            currentHP -= damage;
            lerpTimer = 0f;
            immortalityTimer = 1f;
            combo.comboInt = 0;
            if (currentHP <= 0)
            {
                gameOver.GameOverBlyat();
            }
        }
    }

    public void TakeStamina(float spCost)
    {
        if (currentSP >= spCost)
        {
            currentSP -= spCost;
            lerpTimer = 0f;

            swordAttack.AttackPlayAnimation();
        }  
    }

    public void TakeHP(float vampiricAmmount)
    {
        currentHP += vampiricAmmount;
        if (currentHP > _maxHP)
        {
            currentHP = _maxHP;
        }
    }
}

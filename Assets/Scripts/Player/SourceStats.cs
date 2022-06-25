using UnityEngine;

public class SourceStats : MonoBehaviour
{
    public static float _maxHP = 100f;
    public static float _maxSP = 100f;
    public static float enemyDamage = 20f;
    public static float blockDamage = 5;
    public static float staminaGrow = 10f;
    public static float healthGrow = 1f;
    public static float attackDamage = 10f;
    public static float vampiricAmmount = 5f;
    public static float skillDamage;
    public static float comboRequired;
    public static float maxSkillAmmount;

    void Awake()
    {
        PlayerPrefs.SetFloat("Base HP", _maxHP);
        PlayerPrefs.SetFloat("Base SP", _maxSP);
        PlayerPrefs.SetFloat("Base Enemy Damage", enemyDamage);
        PlayerPrefs.SetFloat("Base Block", blockDamage);
        PlayerPrefs.SetFloat("Base Stamina Grow", staminaGrow);
        PlayerPrefs.SetFloat("Base Health Grow", healthGrow);
        PlayerPrefs.SetFloat("Base Attack Damage", attackDamage);
        PlayerPrefs.SetFloat("Base Vampiric Ammount", vampiricAmmount);
        PlayerPrefs.SetFloat("Base SKill Damage", skillDamage);
        PlayerPrefs.SetFloat("Base Combo", comboRequired);
        PlayerPrefs.SetFloat("Base Maximum Skill Ammount", maxSkillAmmount);
    }
}


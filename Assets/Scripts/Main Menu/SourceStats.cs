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
        PlayerPrefs.GetFloat("Base HP", _maxHP);
        PlayerPrefs.GetFloat("Base SP", _maxSP);
        PlayerPrefs.GetFloat("Base Enemy Damage", enemyDamage);
        PlayerPrefs.GetFloat("Base Block", blockDamage);
        PlayerPrefs.GetFloat("Base Stamina Grow", staminaGrow);
        PlayerPrefs.GetFloat("Base Health Grow", healthGrow);
        PlayerPrefs.GetFloat("Base Attack Damage", attackDamage);
        PlayerPrefs.GetFloat("Base Vampiric Ammount", vampiricAmmount);
        PlayerPrefs.GetFloat("Base SKill Damage", skillDamage);
        PlayerPrefs.GetFloat("Base Combo", comboRequired);
        PlayerPrefs.GetFloat("Base Maximum Skill Ammount", maxSkillAmmount);
    }
}


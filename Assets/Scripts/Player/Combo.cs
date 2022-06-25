using UnityEngine;
using TMPro;

public class Combo : MonoBehaviour
{
    private TextMeshProUGUI comboText;

    public int comboInt;
    private int requiredCombo = 25;
    
    public SpecialSkill skill;

    private void Start()
    {
        comboText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        comboText.text = comboInt.ToString();
    }

    public void IncreaseCombo()
    {
        comboInt++;
        if (comboInt == requiredCombo)
        {
            skill.GiveSpecialSkill();
            comboInt = 0;
        }
    }
}

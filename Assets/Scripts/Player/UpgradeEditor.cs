using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SourceStats))]
public class UpgradeEditor : Editor
{
    private float statsIncreaseAmmount;

    public string[] options = new string[] { "HP", "SP", "Damage Resist", "Stamina Grow", "Health Grow", "Attack Damage", "Vampiric Ammount"};
    public int index = 0;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.Label("Choose stats to increase: ", EditorStyles.boldLabel);

        index = EditorGUILayout.Popup(index, options);

        if (GUILayout.Button("Increase"))
        {
            IncreaseChosenStats();
        }
    }

    void IncreaseChosenStats()
    {
        switch(index)
        {
            case 0:
                SourceStats._maxHP += statsIncreaseAmmount;
                PlayerPrefs.SetFloat("New maximum HP", SourceStats._maxHP);
                break;

            case 1:
                SourceStats._maxSP += statsIncreaseAmmount;
                PlayerPrefs.SetFloat("New maximum SP", SourceStats._maxSP);
                break;

            case 2:
                SourceStats.blockDamage += statsIncreaseAmmount;
                PlayerPrefs.SetFloat("New Damage Resist", SourceStats.blockDamage);
                break;

            case 3:
                SourceStats.staminaGrow += statsIncreaseAmmount;
                PlayerPrefs.SetFloat("New Stamina Grow", SourceStats.staminaGrow);
                break;

            case 4:
                SourceStats.healthGrow += statsIncreaseAmmount;
                PlayerPrefs.SetFloat("New Health Grow", SourceStats.healthGrow);
                break;

            case 5:
                SourceStats.attackDamage += statsIncreaseAmmount;
                PlayerPrefs.SetFloat("New Attack Damage", SourceStats.attackDamage);
                break;

            case 6:
                SourceStats.vampiricAmmount += statsIncreaseAmmount;
                PlayerPrefs.SetFloat("New Vampiric Ammount", SourceStats.vampiricAmmount);
                break;

            default:
                Debug.LogError("Unrecognized Option");
                break;

        }
    }
}

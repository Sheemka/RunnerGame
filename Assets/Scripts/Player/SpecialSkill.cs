using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpecialSkill : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI skillAmmountText;
    private Button specialAbility;
    private Animator animator;

    private int skillAmmount;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        skillAmmountText.text = skillAmmount.ToString();
    }

    public void GiveSpecialSkill()
    {
        skillAmmount++;
        skillAmmountText.enabled = true;
        animator.SetTrigger("isReady");
        specialAbility.enabled = true;
    }

    public void UseSkill()
    {
        if (skillAmmount > 1)
        {
            skillAmmount--;
        }
        else if (skillAmmount == 1)
        {
            skillAmmount--;
            animator.SetTrigger("isUsed");
            specialAbility.enabled = false;
        }
    }
}

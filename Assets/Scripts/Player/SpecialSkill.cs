using UnityEngine;
using TMPro;
using UnityEngine.UI;
//здесь описываю поведение для суператаки или типа того
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
        specialAbility.enabled = true;
        animator.SetTrigger("isReady");
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

using UnityEngine;
using UnityEngine.UI;

public class LocationComplete : MonoBehaviour
{
    [SerializeField] private Image backLCBar;

    private float endLevel = 100f;
    public float levelCompleteness;

    public EnemySpawner spawner;
    public AnimationPlayer playerAnim;
    public MovingBackGround background;
    public MovingGround ground;

    private void Start()
    {
        backLCBar.fillAmount = 0;
    }

    void Update()
    {
        UpdateLC();
    }

    //слайдер для того, сколько осталось до босса и проверка на начало боссфайта
    private void UpdateLC()
    {
        if (levelCompleteness < endLevel)
        {
            levelCompleteness += Time.deltaTime;
            backLCBar.fillAmount = levelCompleteness / 100;
        }
        else
        {
            StartBossFight();
        }
    }

    private void StartBossFight()
    {
        spawner.enabled = false;
        background._speed = 0f;
        ground._speed = 0f;
        playerAnim.StartBossFight();
    }
}

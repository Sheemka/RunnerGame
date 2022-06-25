using UnityEngine;
using UnityEngine.UI;

public class LocationComplete : MonoBehaviour
{
    [SerializeField] private Image backLCBar;

    private float endLevel = 100f;
    public float levelCompleteness;

    public EnemySpawner spawner;

    private void Start()
    {
        backLCBar.fillAmount = 0;
    }

    void Update()
    {
        UpdateLC();
    }

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
    }
}

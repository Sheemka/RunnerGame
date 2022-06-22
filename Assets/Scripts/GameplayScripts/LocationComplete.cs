using UnityEngine;
using UnityEngine.UI;

public class LocationComplete : MonoBehaviour
{
    [SerializeField] private Image backLCBar;

    private float endLevel = 100f;
    private float levelCompleteness;

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
            levelCompleteness += Time.deltaTime / 100;
            backLCBar.fillAmount = levelCompleteness;
        }
        else
        {
            StartBossFight();
        }
    }

    private void StartBossFight()
    {

    }
}

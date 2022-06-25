using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    private TextMeshProUGUI gameOverText;

    public void GameOverBlyat()
    {
        gameOverText = GetComponent<TextMeshProUGUI>();
        gameOverText.enabled = true;
        LoadingScreen.StartLoading("Main Menu");
    }
}

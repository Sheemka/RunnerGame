using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void GameOverBlyat()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

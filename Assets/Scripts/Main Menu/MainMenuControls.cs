using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level";
    public void newGame()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}

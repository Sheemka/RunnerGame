using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level 1";
    public void newGame()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}

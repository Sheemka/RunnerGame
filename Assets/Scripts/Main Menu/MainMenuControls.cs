using UnityEngine;

public class MainMenuControls : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level";

    public void loadScene()
    {
        LoadingScreen.StartLoading(newGameLevel);
    }
}

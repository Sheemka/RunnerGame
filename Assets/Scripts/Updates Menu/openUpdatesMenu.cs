using UnityEngine;

public class openUpdatesMenu : MonoBehaviour
{
    public GameObject UpdateMenu;

    public void OpenUpdateMenu()
    {
        if (UpdateMenu != null)
        {
            UpdateMenu.SetActive(true);
        }
    }
}

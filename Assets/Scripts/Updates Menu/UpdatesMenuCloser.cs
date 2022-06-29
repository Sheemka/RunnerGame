using UnityEngine;

public class UpdatesMenuCloser : MonoBehaviour
{
    public GameObject UpdateMenu;

    public void CloseUpdateMenu()
    {
        if (UpdateMenu != null)
        {
            bool isActive = UpdateMenu.activeSelf;

            UpdateMenu.SetActive(!isActive);
        }
    }
}

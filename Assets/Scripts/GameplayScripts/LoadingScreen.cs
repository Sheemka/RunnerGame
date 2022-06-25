using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    //это нужно для асинхронной загрузки сцен 
    public AsyncOperation loadingScene;
    private Animator animator;
    //это почти синглтон, полезная иногда штука, почитай
    private static LoadingScreen instance;
    private static bool shouldLoad = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        instance = this;
        if (shouldLoad)
        {
            animator.SetTrigger("isLoaded");
        }
    }

    public static void StartLoading(string sceneName)
    {
        instance.animator.SetTrigger("startLoad");
        instance.loadingScene = SceneManager.LoadSceneAsync(sceneName);
        instance.loadingScene.allowSceneActivation = false;
    }

    public void OnAnimationOver()
    {
        shouldLoad = true;
        instance.loadingScene.allowSceneActivation = true;
    }
}

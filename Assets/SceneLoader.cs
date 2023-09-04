using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : Singleton<SceneLoader>
{
    public GameObject loaderUI;
    public Slider progressImage;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }
    public void LoadScene(string sceneName, System.Action callback = null)
    {
        StartCoroutine(LoadSceneCoroutine(sceneName, callback));
    }

    private IEnumerator LoadSceneCoroutine(string sceneName, System.Action callback = null)
    {
        progressImage.value = 0;
        loaderUI.SetActive(true);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;
        while (!asyncOperation.isDone)
        {
            progressImage.value = progress/2;
            if (progress >= .9f)
            {
                Debug.LogError("End Load");
                asyncOperation.allowSceneActivation = true;
            }
            yield return new WaitForEndOfFrame();
        }
        callback.Invoke();
    }
}

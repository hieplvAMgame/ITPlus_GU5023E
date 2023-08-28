using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : Singleton<SceneLoader>
{
    public GameObject loaderUI;
    public Slider progressImage;

    public void LoadScene(int sceneIndex)
    {
        StartCoroutine(LoadSceneCoroutine(sceneIndex));
        
    }

    private IEnumerator LoadSceneCoroutine(int sceneIndex)
    {
        progressImage.value = 0;
        loaderUI.SetActive(true);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneIndex);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;
        while(!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            progressImage.value = progress;
            if (progress >= .9f)
            {
                progressImage.value = 1;
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}

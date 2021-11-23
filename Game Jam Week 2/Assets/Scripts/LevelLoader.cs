using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text progresstText;

    public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
       
    }

      IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        
        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            Debug.Log(operation.progress);
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progresstText.text = progress * 100 + "%";

            yield return null;
        }

    }


}

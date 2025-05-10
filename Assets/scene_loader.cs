using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scene_loader : MonoBehaviour
{
    public Image loadingfill;

    void Start() {
        StartCoroutine(loading());
    }

    IEnumerator loading() {
        AsyncOperation loading = SceneManager.LoadSceneAsync("scene 2");

        while(!loading.isDone) {
            loadingfill.fillAmount = loading.progress/0.9f;
            yield return null;
        }
    }
}

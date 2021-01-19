using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeBeforeLoadAnotherScene : MonoBehaviour
{
    private int TimeVideo = 25;
    public string sceneNameToLoad;

    void Start()
    {
        StartCoroutine(MyCoroutine());

    }

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(TimeVideo);
        print("27 secondes sont passé");

        SceneManager.LoadScene(sceneNameToLoad);

    }

}

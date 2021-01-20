using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToMenu : MonoBehaviour
{

    private int timeToGoLevel1 = 3;
    public string sceneToLoad;

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(timeToGoLevel1);
        SceneManager.LoadScene(sceneToLoad);
    }
}

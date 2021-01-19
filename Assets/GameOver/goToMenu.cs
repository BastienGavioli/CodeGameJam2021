using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToMenu : MonoBehaviour
{

    private int timeToGoMenu = 3;
    public string sceneToLoad;

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(timeToGoMenu);
        SceneManager.LoadScene(sceneToLoad);
    }

}

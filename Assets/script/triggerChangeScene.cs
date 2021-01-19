using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerChangeScene : MonoBehaviour
{

    public string sceneNameToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }

}

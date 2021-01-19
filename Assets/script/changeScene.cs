using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

    public string sceneNameToLoad;
    void Start()
    {
        
    }

    
    void loadThisScene()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }

}

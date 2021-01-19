using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBeforeLoadAnotherScene : MonoBehaviour
{
    private int TimeVideo = 27;
    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(TimeVideo);
        print("27 secondes sont passé");

        changeScene;

    }
    
    void Update()
    {
        
    }
}

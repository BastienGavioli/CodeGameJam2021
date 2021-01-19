using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public int vie = 3;
    public GameObject coeur1;
    public GameObject coeur2;
    public GameObject coeur3;
    public GameObject coeur4;
    public GameObject coeur5;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] tabCoeur = { coeur1, coeur2, coeur3, coeur4, coeur5 };
        coeur1.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
    }
}

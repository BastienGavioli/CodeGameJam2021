﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cliqueObjet : MonoBehaviour
{
    public life pv;
    private int antiVDestroy = 0;

    private Vector3 mousePos = Vector3.zero;
    public GameObject[] tabAntiV;
    private string[] tabNomAntiV;

    public float positionX;
    public float positionY;

    public GameObject camera;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // tabAntiV[0].transform.position = new Vector3(Random.Range(-1106.0f, 1156.0f), 0Random.Range(-40.0f, 0.0f));
            
            positionX = mousePos.x + Random.Range(-5.0f, 5.0f);
            positionY = mousePos.y + Random.Range(-5.0f, 5.0f);

            deplacementObjet(tabAntiV[(int)(Random.Range(0.0f, 8.0f))]);




            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                antiVDestroy++;


                if (hit.collider.gameObject.name == tabAntiV[0].name)
                {
                    tabAntiV[0].SetActive(false);
                }
                else if (hit.collider.gameObject.name == tabAntiV[1].name) {
                    tabAntiV[1].SetActive(false);

                }
                else if (hit.collider.gameObject.name == tabAntiV[2].name)
                {
                    tabAntiV[2].SetActive(false);

                }
                else if (hit.collider.gameObject.name == tabAntiV[3].name)
                {
                    Destroy(tabAntiV[3]);
                }
                else if (hit.collider.gameObject.name == tabAntiV[4].name)
                {
                    Destroy(tabAntiV[4]);
                }
                else if (hit.collider.gameObject.name == tabAntiV[5].name)
                {
                    Destroy(tabAntiV[5]);
                }
                else if (hit.collider.gameObject.name == tabAntiV[6].name)
                {
                    Destroy(tabAntiV[6]);
                }
                else if (hit.collider.gameObject.name == tabAntiV[7].name)
                {
                    Destroy(tabAntiV[7]);
                }
                else if (hit.collider.gameObject.name == tabAntiV[8].name)
                {
                    Destroy(tabAntiV[8]);
                }
                Debug.Log(antiVDestroy);
            }
            else
            {
                SceneManager.LoadScene("GameOver");
            }

        }

        if (antiVDestroy >= 5)
        {
            SceneManager.LoadScene("hackWin");
        }

    }


   

    private bool contact(RaycastHit2D hit)
    {
        for(int i=0; i<8; i++)
        {
            if (hit.collider.gameObject.name == tabAntiV[i].name)
            {
                Debug.Log("OOOOK");
            }
        }
        return true;
    }

    public void estTouche()
    {
        pv.lostxLife(1);
    }

    


    void deplacementObjet(GameObject objet)
    {
        objet.transform.position = new Vector3(positionX, positionY);
    }
  
}

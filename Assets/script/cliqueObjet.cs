using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cliqueObjet : MonoBehaviour
{
    public life pv;
    private int antiVDestroy = 0;

    private Vector3 mousePos = Vector3.zero;
    public GameObject[] tabAntiV;
    private string[] tabNomAntiV;

    public float positionX;
    public float positionY;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // tabAntiV[0].transform.position = new Vector3(Random.Range(-1106.0f, 1156.0f), 0Random.Range(-40.0f, 0.0f));
            positionX = mousePos.x + Random.Range(-5.0f, 5.0f);
            positionY = mousePos.y + Random.Range(-5.0f, 5.0f);

                deplacementObjet(tabAntiV[(int)Random.Range(0.0f, 8.0f)]);
            



                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                
                if (hit.collider.gameObject.name == tabAntiV[0].name)
                {
                    tabAntiV[0].SetActive(false);
                    antiVDestroy++;
                }
                else if (hit.collider.gameObject.name == tabAntiV[1].name) {
                    tabAntiV[1].SetActive(false);
                    antiVDestroy++;

                }
                else if (hit.collider.gameObject.name == tabAntiV[2].name)
                {
                    tabAntiV[2].SetActive(false);
                    antiVDestroy++;

                }
                else if (hit.collider.gameObject.name == tabAntiV[3].name)
                {
                    Destroy(tabAntiV[3]);
                    antiVDestroy++;
                }
                else if (hit.collider.gameObject.name == tabAntiV[4].name)
                {
                    Destroy(tabAntiV[4]);
                    antiVDestroy++;
                }
                else if (hit.collider.gameObject.name == tabAntiV[5].name)
                {
                    Destroy(tabAntiV[5]);
                    antiVDestroy++;
                }
                else if (hit.collider.gameObject.name == tabAntiV[6].name)
                {
                    Destroy(tabAntiV[6]);
                    antiVDestroy++;
                }
                else if (hit.collider.gameObject.name == tabAntiV[7].name)
                {
                    Destroy(tabAntiV[7]);
                    antiVDestroy++;
                }
                else if (hit.collider.gameObject.name == tabAntiV[8].name)
                {
                    Destroy(tabAntiV[8]);
                    antiVDestroy++;
                }
            }

            }

        }


    


        void deplacementObjet(GameObject objet)
        {
            objet.transform.position = new Vector3(positionX, positionY);
        }
  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cliqueObjet : MonoBehaviour
{
    public life pv;
    private int antiVDestroy = 0;

    private Vector3 mousePos = Vector3.zero;
    public GameObject[] tabAntiV;
    public Monster[] actionAntiV;


    public GameObject Player;

    private Vector3 velocity;

    void Start()
    {/*
        for(int i=0; i<tabAntiV.Length; i++)
        {
            tabNomAntiV[i] = tabAntiV[i].name;
        }
        */

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            Debug.Log(hit);

            if (hit.collider != null)
            {
                actionAntiV[0].bouge(Player, velocity);
                Destroy(tabAntiV[contact(hit)]);
                /*
                if (contact(hit)!=-1)
                {
                    hit.collider.attachedRigidbody.AddForce(Vector2.up);
                }*/
            }
        }


    }

  


    private int contact(RaycastHit2D hit)
    {
        int n = -1;
        for(int i=0; i<tabAntiV.Length; i++)
        {
            if(hit.collider.gameObject.name == tabAntiV[i].name)
            {
                n = i;
            }
        }
        return n;
    }

    public void estTouche()
    {
        pv.lostxLife(1);
    }

   
}

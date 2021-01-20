using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cliqueObjet : MonoBehaviour
{
    private Vector3 mousePos = Vector3.zero;
    public GameObject[] tabAntiV;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.name == tabAntiV[1].name)
                {
                    Debug.Log("OOOOK");
                }
            }

        }
    }
}

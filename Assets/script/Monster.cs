
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bouge(GameObject Player, Vector3 velocity)
    {
        transform.position = Vector3.SmoothDamp(transform.position, Player.transform.position, ref velocity, 1);

    }
}

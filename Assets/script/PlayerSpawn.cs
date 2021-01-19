using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
   private void Awake()
    {
        replace();
    }

    public void replace()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position;

    }
}

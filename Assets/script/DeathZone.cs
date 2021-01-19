using UnityEngine;



public class DeathZone : MonoBehaviour
{

    public life playerLife;
    public PlayerMovement movePlayer;
    public PlayerSpawn spawn;

    void Start()
    {
        Debug.Log(playerLife.estMort());

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Player"))
        {
            playerLife.lostxLife(1);
            if (playerLife.estMort())
            //if(true)
            {
                movePlayer.jumpHurt();
            }
            else
            {
                spawn.replace();
                //collision.transform.position = GameObject.FindGameObjectWithTag("PlayerSpawn").transform.position;
            }

        }
    }
    
}

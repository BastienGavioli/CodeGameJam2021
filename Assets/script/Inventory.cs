using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int coinsCount;

    public static Inventory instance;

    public void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance d'Inventory dans la scène");
            return;
        }
        
        instance = this;
    }

    public void AddCoins(int count)
    {
        coinsCount += count;
    }
}

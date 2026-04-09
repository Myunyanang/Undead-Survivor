using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    
    public PoolManager pool;
    public PlayerManager player;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }











}

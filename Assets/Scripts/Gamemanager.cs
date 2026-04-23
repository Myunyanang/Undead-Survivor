using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    public float gameTime;
    public float maxGameTime = 2 * 60f;

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

    void Update()
    {
        gameTime += Time.deltaTime;

        if (gameTime > maxGameTime)
        {
            gameTime = maxGameTime;
        }
    }











}

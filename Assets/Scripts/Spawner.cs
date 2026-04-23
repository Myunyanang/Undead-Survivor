using UnityEngine;

public class Spawner : MonoBehaviour
{
    int level;
    public Transform[] spwnPoint;
    public SpawnData[] spawnData;

    float timer = 0f;

    void Awake()
    {
        spwnPoint = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        level = Mathf.Min((int)(Gamemanager.instance.gameTime / 10f), spawnData.Length - 1);
        timer += Time.deltaTime;

        if (timer > spawnData[level].spawnTime)
        {
            timer = 0f;
            Spawn();
        }
    }
    void Spawn()
    {
        GameObject enemy = Gamemanager.instance.pool.Get(0);
        enemy.transform.position = spwnPoint[Random.Range(1, spwnPoint.Length)].position;
        enemy.GetComponent<Enemy>().Init(spawnData[level]);
    }
}

[System.Serializable]
public class SpawnData
{
    public float spawnTime;

    public int spriteType;
    public int health;
    public float speed;
}

using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spwnPoint;

    float timer = 0f;

    void Awake()
    {
        spwnPoint = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 0.5f)
        {
            timer = 0f;
            Spawn();
        }
    }

    void Spawn()
    {
        GameObject enemy = Gamemanager.instance.pool.Get(Random.Range(0, 2));
        enemy.transform.position = spwnPoint[Random.Range(1, spwnPoint.Length)].position;
    }
}

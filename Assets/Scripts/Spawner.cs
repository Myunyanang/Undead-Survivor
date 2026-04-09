using UnityEngine;

public class Spawner : MonoBehaviour
{
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Gamemanager.instance.pool.Get(1);
            //나중에 뉴인풋으로 바꾸기
        }
    }
}

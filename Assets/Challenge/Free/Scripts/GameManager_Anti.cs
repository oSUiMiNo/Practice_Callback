using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Anti : MonoBehaviour
{
    public static int blockCount = 16;
    
    public static bool gameSet = false;

    public static bool Initialized = false;



    void Start()
    {
        Init();
    }


    public static float timer = 0;
    void Update()
    {
        if ( !gameSet && blockCount == 0)
        {
            timer += Time.deltaTime;
            if(timer >= 0.3)
            {
                Debug.Log("aaa1");
                Exit();
            }
        }

        if( !Initialized && blockCount == 0 )
        {
            timer += Time.deltaTime;
            if (timer >= 4)
            {
                Debug.Log("aaa2");
                timer = 0;
                Init();
            }
        }
    }


    void Init()
    {
        Debug.Log("aaa3");
        blockCount = 16;
        gameSet = false;
        Initialized = true;
    }

    void Exit()
    {
        Debug.Log("aaa4");
        gameSet = true;
        Initialized = false;
    }
}

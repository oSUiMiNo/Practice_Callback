using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Anti : MonoBehaviour
{
    Renderer renderer;
    Collider collider;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        collider= GetComponent<Collider>();

        Init();
    }


    void Update()
    {
        if (!GameManager_Anti.Initialized && GameManager_Anti.blockCount == 0)
        {
            Debug.Log(GameManager_Anti.timer);
            if (GameManager_Anti.timer >= 3)
            {
                Debug.Log("bbb1");
                Init();
            }
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        GameManager_Anti.blockCount--;
        renderer.enabled = false;
        collider.enabled = false;
    }


    void Init()
    {

        renderer.enabled = true;
        collider.enabled = true;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ball_Anti : MonoBehaviour
{
    public float speed = 7;
    Rigidbody rb;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector3(speed, 0, speed);
        }
        
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            rb.AddForce(new Vector3(Random.Range(0, 360), 0, Random.Range(0, 360)).normalized * 700);
        }
        
        if (!GameManager_Anti.Initialized && GameManager_Anti.blockCount == 0)
        {
            rb.velocity = Vector3.zero;
            
            if (GameManager_Anti.timer >= 3)
            {
                Init();
            }
        }

        if (!GameManager_Anti.gameSet) return;

        // 現在の速度を取得
        Vector3 velocity = rb.velocity;
        // (speed ～ speed * 1.5) の範囲内に補正した速度を計算
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, speed, speed * 1.2f);
        // 速度を反映
        rb.velocity = velocity.normalized * clampedSpeed;
    }


    void OnCollisionEnter(Collision collision)
    {
        // プレイヤーに当たったときに、跳ね返る方向を変える
        if (collision.gameObject.tag == "Racket")
        {
            // プレイヤーの位置を取得
            Vector3 playerPos = collision.transform.position;
            // ボールの位置を取得
            Vector3 ballPos = transform.position;
            // プレイヤーから見たボールの方向を計算
            Vector3 direction = (ballPos - playerPos).normalized;
            // 現在の速さを取得
            float speed = rb.velocity.magnitude;
            // 速度を変更
            rb.velocity = direction * speed;
        }
    }

    void Init()
    {
        transform.position = new Vector3(0, 1.4f, -6.5f);
    }
}
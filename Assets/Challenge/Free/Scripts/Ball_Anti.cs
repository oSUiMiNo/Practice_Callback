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

        // ���݂̑��x���擾
        Vector3 velocity = rb.velocity;
        // (speed �` speed * 1.5) �͈͓̔��ɕ␳�������x���v�Z
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, speed, speed * 1.2f);
        // ���x�𔽉f
        rb.velocity = velocity.normalized * clampedSpeed;
    }


    void OnCollisionEnter(Collision collision)
    {
        // �v���C���[�ɓ��������Ƃ��ɁA���˕Ԃ������ς���
        if (collision.gameObject.tag == "Racket")
        {
            // �v���C���[�̈ʒu���擾
            Vector3 playerPos = collision.transform.position;
            // �{�[���̈ʒu���擾
            Vector3 ballPos = transform.position;
            // �v���C���[���猩���{�[���̕������v�Z
            Vector3 direction = (ballPos - playerPos).normalized;
            // ���݂̑������擾
            float speed = rb.velocity.magnitude;
            // ���x��ύX
            rb.velocity = direction * speed;
        }
    }

    void Init()
    {
        transform.position = new Vector3(0, 1.4f, -6.5f);
    }
}
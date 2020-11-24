using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    /// <summary>落下速度</summary>
    [SerializeField] float m_fallSpeed = 15f;
    // Animation用の変数
    Animator m_anim;

    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
        // 落下させる
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * m_fallSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerBulletController>())
        {
            m_anim.Play("AsteroidChange");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        // 画面外に出たら破棄する
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
        }
    }
}

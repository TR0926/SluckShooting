using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    // 隕石のPrefab用の変数
    [SerializeField] GameObject m_asteroidPrefab = null;
    // 生成時のタイムラグ
    [SerializeField, Range(0.1f, 1)] float m_interval = 1f;
    float m_timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 5秒ごとに隕石を生成する
        m_timer += Time.deltaTime;

        if(m_timer > m_interval)
        {
            m_timer = 0;
            Instantiate(m_asteroidPrefab, this.gameObject.transform.position, m_asteroidPrefab.transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenrator : MonoBehaviour
{

    //ボールの箱
    public GameObject ballPrefab;

    //生成間隔
    float span = 1.0f;
    //時間計測
    float delta = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject item = Instantiate(ballPrefab) as GameObject;
            float x = Random.Range(-10, 11);
            item.transform.position = new Vector3(x, 3, 10);
        }
    }
}

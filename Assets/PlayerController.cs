using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigid3D;

    //移動速度
    float walkForce = 200.0f;

    //最大速度
    float maxWalkSpeed = 2.0f;

    // Use this for initialization
    void Start()
    {
        this.rigid3D = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //左右の移動
        int keyX = 0;
        if (Input.GetKey(KeyCode.RightArrow)) keyX = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) keyX = -1;

        //プレイヤーの速度
        float speedx = Mathf.Abs(this.rigid3D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid3D.AddForce(transform.right * keyX * this.walkForce);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            GetComponent<ParticleSystem>().Play();
        }
    }
}

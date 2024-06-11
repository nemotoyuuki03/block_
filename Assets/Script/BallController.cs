using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody myrigidbody;
    void Start()
    {
        //Rigibodyにアクセスして変数に保管しておく
        myrigidbody = GetComponent<Rigidbody>();
        //右斜め45度に進む
        myrigidbody.velocity = new Vector3(speed, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

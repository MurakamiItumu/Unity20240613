using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourScript : MonoBehaviour
{
    //ボールの移動の速さを指定
    public float speed = 5f;
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbodyにアクセスして変数に保持しておく
        myRigidbody= GetComponent<Rigidbody>();
        //右斜め45度に進んでいく
        myRigidbody.velocity = new Vector3(speed,speed,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

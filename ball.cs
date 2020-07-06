using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    //GUIで数字を変更できるようにするため,publicを使う
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //floatの場合は数字にfを追加する
        speed = 10.0f;
        GetComponent<Rigidbody>().AddForce((transform.right - transform.up) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

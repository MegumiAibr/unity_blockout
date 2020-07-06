using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collison)

    {
        //点数を加点する時に使える　UNITY講習会ではコメントアウト
        //Score.score++;

        Destroy(gameObject);
        /* スクリプトリファレンス
         * public static void Destroy (Object obj消すオブジェクトの指定,float t= 0.0F消えるまでの時間);
         */

    }
}

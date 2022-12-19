using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour
{
    //カメラオブジェクト
    private GameObject maincamera;

    // Start is called before the first frame update
    void Start()
    {
        this.maincamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z <= maincamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}

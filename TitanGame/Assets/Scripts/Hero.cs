using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var height = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, Screen.height / 3.0f, 0.0f)).y;
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

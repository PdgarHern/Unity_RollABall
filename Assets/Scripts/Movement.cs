using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;

    float xO = 0;
    float zO = 0;

    void Start() {
        transform.position = new Vector3(50,0,0);
        speed = 2;
        width = 7.5f;
        height = 7.5f;

    }

    void Update() {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = 0.5f;
        float z = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x + xO, y, z + zO);
        
    }
}

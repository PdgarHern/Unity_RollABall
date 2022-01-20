using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement7 : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;

    float xO = 0;
    float zO = -45;

    void Start() {
        transform.position = new Vector3(50,0,0);
        speed = 4;
        width = 5f;
        height = 5f;

    }

    void Update() {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = 0.5f;
        float z = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x + xO, y, z + zO);
        
    }
}

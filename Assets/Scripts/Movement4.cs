using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement4 : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;

    float xO = -40;
    float zO = -3;

    void Start() {
        transform.position = new Vector3(50,0,0);
        speed = 2;
        width = 0;
        height = 10f;

    }

    void Update() {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = 2;
        float z = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x + xO, y, z + zO);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement9 : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;

    float xO = 59.98f;
    float zO = -57.79f;

    void Start() {
        transform.position = new Vector3(50,0,0);
        speed = 2;
        width = 2f;
        height = 4f;

    }

    void Update() {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = 6.75f;
        float z = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x + xO, y, z + zO);
        
    }
}

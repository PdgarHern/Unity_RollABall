using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3 : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;

    float xO = -41;
    float zO = -46;

    void Start() {
        transform.position = new Vector3(50,0,0);
        speed = 2;
        width = 1.5f;
        height = 16f;

    }

    void Update() {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = 27.1f;
        float z = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x + xO, y, z + zO);
        
    }
}

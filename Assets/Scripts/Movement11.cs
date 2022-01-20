using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement11 : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;

    float xO = 62.35f;
    float zO = -33.57f;

    void Start() {
        transform.position = new Vector3(50,0,0);
        speed = 4;
        width = 2f;
        height = 4f;

    }

    void Update() {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = 6.25f;
        float z = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x + xO, y, z + zO);
        
    }
}

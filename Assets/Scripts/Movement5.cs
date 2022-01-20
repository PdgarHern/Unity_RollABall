using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement5 : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;

    float xO = -48.25f;
    float zO = -7.75f;

    void Start() {
        transform.position = new Vector3(50,0,0);
        speed = 2;
        width = 2;
        height = 2f;

    }

    void Update() {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = 6.6f;
        float z = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x + xO, y, z + zO);
        
    }
}

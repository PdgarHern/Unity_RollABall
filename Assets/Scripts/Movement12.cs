using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement12 : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;

    float xO = 52.32f;
    float zO = -40.69f;

    void Start() {
        transform.position = new Vector3(50,0,0);
        speed = 7;
        width = 2f;
        height = 4f;

    }

    void Update() {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = 4.75f;
        float z = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x + xO, y, z + zO);
        
    }
}

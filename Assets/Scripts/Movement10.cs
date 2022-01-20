using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement10 : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;

    float xO = 67.55f;
    float zO = -48.75f;

    void Start() {
        transform.position = new Vector3(50,0,0);
        speed = 5;
        width = 2f;
        height = 4f;

    }

    void Update() {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = 7.75f;
        float z = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x + xO, y, z + zO);
        
    }
}

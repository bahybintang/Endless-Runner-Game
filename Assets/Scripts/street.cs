using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class street : MonoBehaviour {

    public float speed = 10;
    public float batas = -120;

    void Update()
    {
        if (transform.position.x < -120)
        {
            Destroy(transform.gameObject);
        }

        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
    }
}

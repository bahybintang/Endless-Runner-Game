using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    
    public int divider;
    private int time = 0, score = 0;

	void Update () {
        TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
        time += (int) (Time.deltaTime*1000);
        score = time / divider;
        t.text = score + "";
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar : MonoBehaviour {

	void Update() { 
            GameObject player = GameObject.FindWithTag("Player");
            int health = player.GetComponent<PlayerController>().health;
            TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
            t.text = health + "";
    }
}

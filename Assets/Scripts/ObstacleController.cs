using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    public float speed;

    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        int health = player.GetComponent<PlayerController>().health;
        if (transform.position.x < -10 || health == 0)
        {
            Destroy(transform.root.gameObject);
        }

        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerController>().health--;
            Destroy(gameObject);
        }
    }
}
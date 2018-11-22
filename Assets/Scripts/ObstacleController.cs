using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    public float speed;

    void Update()
    {
        if (transform.position.x < -10)
        {
            Destroy(transform.root.gameObject);
        }

        transform.Translate(Vector3.left * speed * Time.deltaTime);
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
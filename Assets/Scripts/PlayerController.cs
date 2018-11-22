using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float increment;
    public float maxZ;
    public float minZ;

    private Vector3 targetPos;

    public int health;

    public GameObject restartDisplay;
    public GameObject spawner;
    
    private void Update()
    {

        if (health <= 0)
        {
            spawner.SetActive(false);
            restartDisplay.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.z == 0)
        {
            targetPos = new Vector3(transform.position.x, transform.position.y, -increment);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.z > 0 && transform.position.z > minZ)
        {
            targetPos = new Vector3(transform.position.x, transform.position.y, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.z < 0  && transform.position.z < maxZ)
        {
            targetPos = new Vector3(transform.position.x, transform.position.y, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.z == 0)
        {
            targetPos = new Vector3(transform.position.x, transform.position.y, increment);
        }
    }
}
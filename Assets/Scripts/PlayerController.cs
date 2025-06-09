using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float horizonalInput;
    public float speed = 10.0f;
    public float xRange = 20;

    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        horizonalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizonalInput * Time.deltaTime * speed);

        if (transform.position.x < xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            // launch projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}

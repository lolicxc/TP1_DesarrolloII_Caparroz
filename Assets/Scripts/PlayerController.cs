using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    [SerializeField] private float rotationSpeed = 0f;
    // Update is called once per frame
    void Update()
    {

        float movementY = 0f;

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate (Vector3.down * rotationSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            movementY = 1f;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            movementY = -1f;
        }

        Vector3 movement = new Vector3 (Input.GetAxis("Horizontal"), movementY, Input.GetAxis("Vertical"));
        transform.position += movement * speed * Time.deltaTime;

    }
}

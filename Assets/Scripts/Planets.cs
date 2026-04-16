using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UIElements;

public class Planets : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    [SerializeField] private Transform center;
    [SerializeField] private float radius = 3f;
    [SerializeField] private float angle = 0f;
    [SerializeField] private float rotationSpeed;
    private float x;
    private float z;
 
    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;
        x = center.position.x + radius * Mathf.Cos(angle);
        z = center.position.z + radius * Mathf.Sin(angle);
        transform.position = new Vector3(x,center.position.y,z);

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}

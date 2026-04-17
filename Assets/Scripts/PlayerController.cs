using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    [SerializeField] private EngineController rightEngine;
    [SerializeField] private EngineController leftEngine;   
    // Update is called once per frame
    void Update()
    {


        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxisRaw("Horizontal");   // -1 | 0 | 1
                                                       //movement.x = Input.GetAxis("Horizontal");    // -1 > < 1
        direction.y = 0;
        direction.z = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.Space))
            direction.y = 1;

        if (Input.GetKey(KeyCode.LeftControl))
            direction.y = -1;

        direction.Normalize();
        //movement = movement.normalized;

        Vector3 movement = direction * (speed * Time.deltaTime);
        transform.Translate(movement);

        leftEngine.Set(direction.x < 0);
        rightEngine.Set(direction.x > 0);


    }
}

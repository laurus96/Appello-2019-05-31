using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 10.0f;

    private Rigidbody rg;

    // Start is called before the first frame update
    void Start()
    {
        rg = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical") * playerSpeed;
        float moveHorizontal = Input.GetAxis("Horizontal") * playerSpeed;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rg.AddForce(movement);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float forwardMultiplier;
    [SerializeField] private float lateralMultiplier;
    private CharacterController controller;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void Update()
    {
        GoForward();
    }

    private void GoForward()
    {
        controller.Move(Vector3.forward * Player.Instance.PlayerMovementSpeed * Time.deltaTime);

        //rb.AddForce(new Vector3(0, 0, Player.Instance.PlayerMovementSpeed) * Time.fixedDeltaTime, ForceMode.Force);
        //t
        //if (rb.velocity.magnitude > Player.Instance.PlayerMovementSpeed)
        //{
        //    rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Player.Instance.PlayerMovementSpeed);
        //}
        //rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Player.Instance.PlayerMovementSpeed);
    }

}

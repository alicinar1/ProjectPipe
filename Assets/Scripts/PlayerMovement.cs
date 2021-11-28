using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float forwardMultiplier;
    [SerializeField] private float lateralMultiplier;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GoForward();
    }

    private void GoForward()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 10);
    }

    public void MoveRight()
    {
        rb.AddForce(Vector3.right * lateralMultiplier * Time.deltaTime, ForceMode.Impulse);
    }

    public void MoveLeft()
    {
        rb.AddForce(Vector3.left * lateralMultiplier * Time.deltaTime, ForceMode.Impulse);
    }
}

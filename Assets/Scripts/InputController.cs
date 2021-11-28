using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PipeMovementControlller pipeMovementControlller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //playerMovement.MoveRight();
            pipeMovementControlller.TurnPipeRight();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //playerMovement.MoveLeft();
            pipeMovementControlller.TurnPipeLeft();
        }
    }
}

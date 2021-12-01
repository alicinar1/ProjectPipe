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
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            //playerMovement.MoveRight();
            pipeMovementControlller.TurnPipeRight(touch.deltaPosition.x);
            Debug.Log(touch.deltaPosition.x);
        }
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    //playerMovement.MoveLeft();
        //    pipeMovementControlller.TurnPipeLeft();
        //}
    }
}

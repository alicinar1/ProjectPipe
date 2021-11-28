using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementControlller : MonoBehaviour
{
    public void TurnPipeRight()
    {
        this.gameObject.transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * 100);
    }

    public void TurnPipeLeft()
    {

        this.gameObject.transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * 100);
    }
}

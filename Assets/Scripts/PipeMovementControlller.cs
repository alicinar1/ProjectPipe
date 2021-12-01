using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementControlller : MonoBehaviour
{
    public void TurnPipeRight(float pixelCount)
    {
        this.gameObject.transform.Rotate(new Vector3(0, 0, 3) * Time.deltaTime * pixelCount);
    }

    public void TurnPipeLeft(float pixelCount)
    {

        this.gameObject.transform.Rotate(new Vector3(0, 0, -3) * Time.deltaTime * pixelCount);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform cameraPos;
    [SerializeField] private Transform pipePos;
    [SerializeField] private float zOffset;
    [SerializeField] private float yOffset;
    [SerializeField] private float xAngleOffset;

    private void Start()
    {
        
    }
    private void Update()
    {
        SetCameraPosition();
    }

    private void SetCameraPosition()
    {
        cameraPos.rotation = Quaternion.Euler(xAngleOffset, 0f, pipePos.rotation.z * 0.5f + Player.Instance.transform.rotation.z * 0.5f);
        cameraPos.position = new Vector3(0, yOffset, Player.Instance.transform.position.z - zOffset);
    }
}

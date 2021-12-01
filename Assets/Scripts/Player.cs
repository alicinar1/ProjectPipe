using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoSingleton<Player>
{
    [SerializeField] private float playerMovementSpeed;
    //public float PlayerMovementSpeed { get { return playerMovementSpeed;  } set { value = playerMovementSpeed; } }
    public int PlayerMovementSpeed { get; set; }

    private void Start()
    {
        PlayerMovementSpeed = 15;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.GameOver();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    GameManager.Instance.GameOver();
        //    Debug.Log(collision.gameObject.tag);
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private CharacterController controller;
    private Vector3 move;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move);
    }
}

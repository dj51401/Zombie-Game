using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{   

    public float moveSpeed = 5.0f;
    public float gravity = 10;

    CharacterController controller;
    Transform target;
    GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        target = player.transform;

        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;

        Vector3 velocity = direction * moveSpeed;
        velocity.y = -2f;
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}

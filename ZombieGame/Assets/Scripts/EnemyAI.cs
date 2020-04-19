using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{   

    public float moveSpeed = 5.0f;
    public float gravity = 10;
    public int enemyHealth = 100;
    public static float playerHealth = 100;
    public int damage = 20;

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


        if (enemyHealth <= 0)
        {
            enemyHealth = 0;
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullets")
        {
            enemyHealth -= 25;
            Destroy(collision.gameObject);
        }
    }
}

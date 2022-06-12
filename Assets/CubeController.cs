using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;
    private float deadline = -10;
    private float isGround = 6;

    AudioSource cubeSound;
    
    // Start is called before the first frame update
    void Start()
    {
        cubeSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime,0,0);
        if(transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }

        if(transform.position.y == this.isGround)
        {
            cubeSound.Play();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cube")
        {
            cubeSound.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float LifeDuration = 1f;

    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = LifeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        timer -= Time.deltaTime;
        if (timer <= 0)
        { 
            Destroy(this.gameObject);
        }
    }
}

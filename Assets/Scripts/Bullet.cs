using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
<<<<<<< Updated upstream
    public GameObject particles;
    public Vector2 direction;
    public float speed = 20;
    public float lifeTime = 2;
    public Vector2 damageRange = new Vector2(10, 20);
    
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("SelfDestruct", lifeTime);
    }

    void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        //if(other.gameObject.CompareTag("Player")) return;
        
        //TODO: get health component
        var damage = Random.Range(damageRange.x, damageRange.y);

        //DamageIndicator.instance.ShowDamage((int)damage, transform.position);

        //print("Hit " + other.gameObject.name + " for " + damage + " damage");
        var health = other.gameObject.GetComponent<Health>();
        if(health != null)
        {
            health.TakeDamage((int)damage);
        }
        SelfDestruct();

    }

    void SelfDestruct()
    {
        Instantiate(particles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
=======
    public Vector3 direction;
    public float speed = 30;
    public float lifeTime = 2;
    public Vector2 damageRange = new Vector2(10, 20);

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direction * speed;

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        var damage = Random.Range(damageRange.x, damageRange.y);

        //TODO:

        //
        //print($"Dealt {damage} damage to {other.gameObject.name}");
        var health = other.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage((int)damage);

            
        }
        Destroy(gameObject);
    }
}
//>>>>>>> Stashed changes

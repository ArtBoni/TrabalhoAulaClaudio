using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            life -= collision.gameObject.GetComponent<Bullet>().damage;
            Destroy(collision.gameObject);
            if (life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

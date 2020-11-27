using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
   public float speed = 20f;
    public Rigidbody2D rb;

    public int damage = 5;
    
    private void Start() {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 10f);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        Player player = hitInfo.GetComponent<Player>();
        if(player != null){
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float damage = 10f;

    private bool movingRight = true;

    public Transform groundDetection;
    public Transform firePoint;
    public float rayDis = 1f;
    public float visionDis = 10f;

    public GameObject enemyBullet;

    private void Update() {
        
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, Vector2.right, visionDis);
        Player player = hitInfo.transform.GetComponent<Player>();
        if(player != null){
            Instantiate(enemyBullet, firePoint.position, firePoint.rotation);
        }
        else{
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, rayDis);
            if(groundInfo.collider == false){
                if(movingRight){
                    transform.eulerAngles = new Vector3(0, -180, 0);
                    movingRight = false;
                }
                else {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    movingRight = true;
                }
        }
        }
    }
}

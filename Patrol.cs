using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;

    private bool movingRight = true;
    private bool playerDetected = false;

    public Transform groundDetection;
    public Transform firePoint;
    public float rayDis = 1f;
    public float visionDis = 10f;

    public GameObject enemyBullet;

    private void Update() {
        if(playerDetected == false){
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, rayDis);
            if(groundInfo.collider == false){
                if(movingRight){
                    transform.Rotate (0f, 180f, 0f);
                    movingRight = false;
                }
                else{
                    transform.Rotate (0f, 0f, 0f);
                    movingRight = true;
                }
            }
        CastRay();
        //Debug.Log(player);
        }
    }

    public void CastRay(){
        if(movingRight == true){
            RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, Vector2.right, visionDis);
            Player player = hitInfo.transform.GetComponent<Player>();
            if(player != null){
                playerDetected = true;
                Instantiate(enemyBullet, firePoint.position, firePoint.rotation);
                playerDetected = false;
            }
        }
        else{
            RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, Vector2.left, visionDis);
            Player player = hitInfo.transform.GetComponent<Player>();
            if(player != null){
                playerDetected = true;
                Instantiate(enemyBullet, firePoint.position, firePoint.rotation);
                playerDetected = false;
            }
        }    
        
        //Debug.Log("Check
    }
}

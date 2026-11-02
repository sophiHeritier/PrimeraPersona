using UnityEngine;

public class ReceiveDamage : MonoBehaviour
{
    public int health = 100;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Debug.Log("Received damage from projectile!");
           
            Destroy(collision.gameObject);

            health -= 10; 

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    
}

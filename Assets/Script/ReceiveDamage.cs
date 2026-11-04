using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReceiveDamage : MonoBehaviour
{
    public TextMeshProUGUI healthText;
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

            health -= 20; 
            healthText.text = health.ToString();

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    
}

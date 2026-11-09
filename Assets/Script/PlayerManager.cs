using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    [Header("Vida")]
    public int maxHealth = 100;
    public int currentHealth;
    public TextMeshProUGUI healthText;
    public Image healthBar;

    [Header("Monedas / Puntuación")]
    public int coins = 0;
    public TextMeshProUGUI coinsText;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateUI();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;

        UpdateUI();

        if (currentHealth <= 0)
        {
            GameManager.Instance.TriggerDefeat();
        }
    }

   
    public void AddCoins(int amount)
    {
        coins += amount;
        UpdateUI();

     
        if (coins >= 5)
        {
            GameManager.Instance.TriggerVictory();
        }
    }

    void UpdateUI()
    {
        if (healthText != null) healthText.text = currentHealth.ToString();
        if (healthBar != null) healthBar.fillAmount = (float)currentHealth / maxHealth;
        if (coinsText != null) coinsText.text = coins.ToString();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10); 
        }
    }
}

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

    // Recibir daño (por ejemplo, cuando el enemigo choca o ataca al jugador)
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

    // Recoger monedas
    public void AddCoins(int amount)
    {
        coins += amount;
        UpdateUI();

        // Opcional: Condición de victoria por acumular cierta cantidad de monedas (ej. 5 monedas)
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

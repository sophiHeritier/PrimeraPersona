using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1; // Cuántas monedas vale esta moneda

    private void OnTriggerEnter(Collider other)
    {
        // Detecta si el objeto que toca la moneda es el Jugador
        if (other.CompareTag("Player"))
        {
            PlayerManager player = other.GetComponent<PlayerManager>();

            if (player != null)
            {
                player.AddCoins(coinValue); // Le suma la moneda al jugador
                Destroy(gameObject);        // Destruye la moneda de la escena
            }
        }
    }
}
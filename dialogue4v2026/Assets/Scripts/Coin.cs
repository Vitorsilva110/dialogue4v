using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerCoinCollector player =
                other.GetComponent<PlayerCoinCollector>();

            player.AddCoin();

            Destroy(gameObject);
        }
    }
}
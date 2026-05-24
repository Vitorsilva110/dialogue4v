using UnityEngine;

public class PlayerCoinCollector : MonoBehaviour
{
    int coins = 0;

    public void AddCoin()
    {
        coins++;

        PlayerOM.CollectCoin(coins);

        Debug.Log("Moedas: " + coins);
    }
}
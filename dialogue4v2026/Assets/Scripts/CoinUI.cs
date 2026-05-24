using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    void OnEnable()
    {
        PlayerOM.OnCoinCollected += UpdateCoins;
    }

    void OnDisable()
    {
        PlayerOM.OnCoinCollected -= UpdateCoins;
    }

    void UpdateCoins(int amount)
    {
        coinText.text =
            "Moedas: " + amount;
    }
}
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    [Header("UI")]
    public Slider healthSlider;
    public Image fillImage;

    [Header("Health Colors")]
    public Color fullHealthColor = Color.green;
    public Color halfHealthColor = Color.yellow;
    public Color lowHealthColor = Color.red;

    void Start()
    {
        currentHealth = maxHealth;

        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;

        UpdateHealthBar();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Health ko 0 se neeche na jane do
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateHealthBar();

        Debug.Log("Player Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Player Died");
        }
    }

    void UpdateHealthBar()
    {
        healthSlider.value = currentHealth;

        float healthPercent = (float)currentHealth / maxHealth;

        if (healthPercent > 0.5f)
        {
            fillImage.color = fullHealthColor;
        }
        else if (healthPercent > 0.2f)
        {
            fillImage.color = halfHealthColor;
        }
        else
        {
            fillImage.color = lowHealthColor;
        }
    }
}
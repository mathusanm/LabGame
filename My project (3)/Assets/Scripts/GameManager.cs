using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Health")]
    public int maxHealth;
    public int currentHealth;
    public Image[] health;
    [SerializeField] int healthIndex;

    [Header("Game Status")]
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null) 
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayHealth()
    {
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        for (int i = 0; i< health.Length; i++)
        {
            healthIndex = Mathf.Abs(currentHealth - maxHealth);

            health[i].enabled = false;

            health[healthIndex].enabled = true;
        }
    }
}

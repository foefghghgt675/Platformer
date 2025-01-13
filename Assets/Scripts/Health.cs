<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public AudioClip damageSound;

=======
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
>>>>>>> Stashed changes
    public int maxHealth = 6;
    public List<Image> hearts;
    public Sprite fullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;
<<<<<<< Updated upstream
    public UnityEvent onDamage;
    public UnityEvent onDeath;

    private int health;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        audioSource.PlayOneShot(damageSound);
        
        health -= damage;
        onDamage.Invoke();

        if (health < 0)
        {
            health = 0;
            onDeath.Invoke();
        }

        UpdateHearts();

       //TODO: death event or reload
    }

=======

    private int health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

   
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        UpdateHearts();
    }
>>>>>>> Stashed changes
    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Count; i++)
        {
            if (health >= (i + 1) * 2)
            {
                hearts[i].sprite = fullHeart;
            }
<<<<<<< Updated upstream
            else if(health == (i * 2) + 1)
=======
            else if (health == (i * 2) + 1)
>>>>>>> Stashed changes
            {
                hearts[i].sprite = halfHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
<<<<<<< Updated upstream
        }
    }
}
=======
        } 
    }
}

>>>>>>> Stashed changes

using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public PlayerHealth pHealth;
    public float damage;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            pHealth.health -= damage;
        }

        if (pHealth.health <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}

using UnityEngine;

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
    }
}

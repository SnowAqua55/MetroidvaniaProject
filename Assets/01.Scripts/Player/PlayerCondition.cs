using UnityEngine;

public class PlayerCondition : MonoBehaviour, IDamageable
{
	[SerializeField] private Condition health;

    private bool isDead = false;

    public void TakeDamage(float value)
    {
        if (isDead) return;
        health.Subtract(value);
        if (health.curValue <= health.deathValue) Die();
    }

    public void TakeHeal(float value)
    {
        if (isDead) return;
        health.Add(value);
    }

    public void Die()
    {
        Destroy(gameObject);
        isDead = true;
    }
}
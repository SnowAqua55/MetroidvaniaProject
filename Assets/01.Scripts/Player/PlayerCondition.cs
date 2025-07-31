using UnityEngine;

public class PlayerCondition : MonoBehaviour, IDamageable
{
	private Condition health;

    private void Update()
    {
        
    }

    public void TakeDamage(float value)
    {
        health.Subtract(value);
    }

    public void TakeHeal(float value)
    {
        health.Add(value);
    }
}
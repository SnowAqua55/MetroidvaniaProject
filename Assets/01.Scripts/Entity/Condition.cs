using UnityEngine;
using UnityEngine.UI;

public interface IDamageable
{
	void TakeDamage(float value);
    void TakeHeal(float value);
    void Die();
}

public class Condition : MonoBehaviour
{
    public float curValue;
	public float maxValue;
    public float passiveValue;
    public float deathValue = 0.0f;
    public Image uiBar;

    void Start()
    {
        curValue = maxValue;
    }

    private void Update()
    {
        uiBar.fillAmount = GetPercentGuage();
    }

    private float GetPercentGuage()
    {
        return curValue / maxValue;
    }

    public void Add(float value)
    {
        curValue = Mathf.Min(curValue + value, maxValue);
    }

    public void Subtract(float value)
    {
        curValue = Mathf.Max(curValue - value, deathValue);
    }
}
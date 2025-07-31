using UnityEngine;

public interface IDropItem
{
    void ItemDrop(ItemData itemData);
}


public class DropItem : MonoBehaviour
{
    public ItemData itemData;

    private void Start()
    {
        if (itemData != null)
        {
            GetComponent<SpriteRenderer>().sprite = itemData.icon;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }


}
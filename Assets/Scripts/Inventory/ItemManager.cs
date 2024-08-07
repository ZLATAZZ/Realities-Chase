using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject ItemContainer;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void ListItems()
    {

        foreach(Transform t in ItemContent) {

            Destroy(t.gameObject);
        }

        foreach (var item in Items)
        {
            GameObject obj = Instantiate(ItemContainer, ItemContent);

            var itemImage = obj.transform.Find("ItemIcon").GetComponent<Image>();


            itemImage.sprite = item.icon;

        }
    }
}

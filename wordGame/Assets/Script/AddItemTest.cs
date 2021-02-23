using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemTest : MonoBehaviour
{
    public ItemScript item;
    public BagScript bag;

    public void AddNewItem() {
        print("test succes");
        if (!bag.itemList.Contains(item)) {
            bag.itemList.Add(item);
            item.ItemNumber++;
        } else {
            item.ItemNumber++;
        }

        BagMannager.RefreshItem();
    }
}

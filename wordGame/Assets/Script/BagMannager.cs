using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagMannager : MonoBehaviour
{
    static BagMannager instance;

    public BagScript bag;
    public GameObject slotGrid;
    public Slot slotPrefab;
    public UnityEngine.UI.Text itemInformation;

    void Awake() {
        if (instance != null)
            Destroy(this);
        instance = this;
    }

    private void OnEnable() {
        RefreshItem();
        instance.itemInformation.text = "";
    }

    public static void UpdateItemInfo(string itemDescription) {
        instance.itemInformation.text = itemDescription;
    }

    public static void CreateNewItem(ItemScript item) {
        Slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.ItemICon;
        newItem.slotNumber.text = item.ItemNumber.ToString();
    }

    public static void RefreshItem() {
        for(int i = 0; i < instance.slotGrid.transform.childCount; i++) {
            if (instance.slotGrid.transform.childCount == 0)
                break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }

        for(int i =0; i< instance.bag.itemList.Count; i++) {
            CreateNewItem(instance.bag.itemList[i]);
        }
    }
}

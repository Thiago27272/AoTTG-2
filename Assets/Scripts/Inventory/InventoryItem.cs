using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.UI.Radial;

namespace Assets.Scripts.Inventory
{

    [System.Serializable]
    [CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Items")]
    public class InventoryItem : ScriptableObject
    {

        public string itemName;
        public string itemDesc;
        public SpriteRenderer itemImage;
        public RadialMenu itemMenu;

    }

}

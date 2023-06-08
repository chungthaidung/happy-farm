using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HappyFarm
{
    public class PlotView : MonoBehaviour
    {
        public void OnMouseDown()
        {
            UnityEngine.Debug.Log("Choose seed");
            GameplayController.Instance.ShowSeedInventory(transform.position);
        }
    }

}

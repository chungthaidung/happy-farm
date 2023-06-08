using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HappyFarm
{
    public class SeedInvController : MonoBehaviour
    {
        public void OnCloseButtonClicked()
        {
            Debug.Log("close ui");
            GameplayController.Instance.CloseSeedInventory();

        }
        public void OnTomatoSeedClicked()
        {
            Debug.Log("OnTomatoSeedClicked");
            GameplayController.Instance.CloseSeedInventory();


        }
        public void OnBlueberrySeedClicked()
        {
            Debug.Log("OnTomatoSeedClicked");
            GameplayController.Instance.CloseSeedInventory();


        }
        public void OnStrawBerrySeedClicked()
        {
            Debug.Log("OnTomatoSeedClicked");
            GameplayController.Instance.CloseSeedInventory();

        }
    }

}

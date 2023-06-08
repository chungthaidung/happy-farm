using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyFarm
{
    public class MainMenuController : MonoBehaviour
    {
        public static MainMenuController Instance;
        private void Start()
        {
            Instance = this;
        }

        public void OnShopClick()
        {
            // AppManager.Instance.Switch(new AppState)
        }
    }

}

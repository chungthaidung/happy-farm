using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HappyFarm
{
    public class GameplayController : MonoBehaviour
    {
        private bool _disableClick = false;
        public static GameplayController Instance;
        private GameplayModel _gameplayModel;
        private Canvas _seedInvUI;
        private int _chosenId;
        private void Start()
        {
            Instance = this;
            _gameplayModel = new GameplayModel();
            _chosenId = -1;
        }
        public bool DisableClick
        {
            get { return _disableClick; }
            set { _disableClick = value; }
        }
        public GameplayModel GameplayModel
        {
            get { return _gameplayModel; }
        }
        public void ShowSeedInventory(Vector3 _chosenPlot)
        {
            if (!_disableClick)
            {
                _seedInvUI = UIManager.Instance.ShowUI("SeedInv");
               _chosenId = _gameplayModel.FindPlot(_chosenPlot);
               UnityEngine.Debug.Log(_chosenId);
                _disableClick = true;
            }
        }
        public void CloseSeedInventory()
        {
            if (_seedInvUI != null)
            {
                UIManager.Instance.ReleaseUI(_seedInvUI, true);
                _seedInvUI = null;
                _disableClick = false;
            }
        }
        public void OnSeedButtonClicked(int type)
        {

        }
    }

}

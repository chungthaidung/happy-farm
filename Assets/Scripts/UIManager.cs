using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyFarm
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance;
        [SerializeField]
        private Canvas _mainCanvas;
        [SerializeField]
        private GameObject _rect;
        private List<Canvas> _canvasPool;
        public Canvas ShowUI(string uiName)
        {
            Canvas _newUI = Resources.Load<Canvas>("UIPrefabs/"+ uiName);
            UnityEngine.Debug.Log(_newUI);

            if (_newUI != null)
            {
                Canvas _ui =Instantiate(_newUI);
                _ui.transform.SetParent(_rect.transform);
                return  _ui;
            }
            else 
            {
                UnityEngine.Debug.Log("error show ui");
            }
            return null;
        }
        public void ReleaseUI(Canvas ui,bool destroy)
        {
            if (destroy)
            {
                Destroy(ui.gameObject);
            } else
            {
                _canvasPool.Add(ui);
                ui.gameObject.SetActive(false);
            }
        }
        public void ReleaseAllUI()
        {
            Canvas[] listCanvas = GetComponentsInChildren<Canvas>();
            foreach (Canvas _uiCanvas in listCanvas)
            {
                Destroy(_uiCanvas.gameObject);
            }
        }
        private void Awake() {
            DontDestroyOnLoad(this);
        }
        void Start()
        {
            Instance = this;
        }

        
    }

}

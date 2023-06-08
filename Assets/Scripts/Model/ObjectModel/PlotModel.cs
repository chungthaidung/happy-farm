using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyFarm.Config;
namespace HappyFarm
{
    public class PlotModel
    {
        private int _id;
        private int _status;
        private int _seedTypes = -1;
        private int _currentCropsNumber = -1;
        // private bool _isLastCrop;
        private int _unharvestedCrops;
        private GameObject _objectView;
        public GameObject ObjectView {
            get {return _objectView;}
            set {_objectView = value;}
        }
        public int PlotId
        {
            get {return _id;}
        }
        public PlotModel(int id) 
        {
            _id = id;
            _status = GameConfig.LOCKED_PLOT;
        }
    }

}
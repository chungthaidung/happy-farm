using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyFarm
{
    public class GameplayModel
    {
        private LandModel _landModel;
        private List<Seed> _seedInv;
        public GameplayModel()
        {
            _landModel = new LandModel();
        }
        public int FindPlot(Vector3 plot)
        {
            return _landModel.GetPlotIdFromPosition(plot);
        }
    }
}


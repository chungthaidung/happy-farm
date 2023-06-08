using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using HappyFarm.Utils;
namespace HappyFarm
{
    public class LandModel
    {
        public List<Vector2> _cropsPosition = new List<Vector2>();
        public const int MAX_PLOT = 6;
        private int _id;
        private int _landType;
        private List<PlotModel> _plots;
        public LandModel()
        {
            CropsPosData();
            _plots = new List<PlotModel>();
            PlotModel _tempPlot;
            for (int i = 0; i < MAX_PLOT; i++)
            {
                _tempPlot = new PlotModel(i);
                _plots.Add(_tempPlot);
            }
            // UnityEngine.Debug.Log(JsonConvert.SerializeObject(_plots));
            FirstSpawnPlot();
        }
        public void CropsPosData()
        {
            _cropsPosition.Add(new Vector2(-5.67f,2.06f));
            _cropsPosition.Add(new Vector3(0.02f,2.06f));
            _cropsPosition.Add(new Vector2(5.66f,2.06f));
            _cropsPosition.Add(new Vector2(-5.67f,-2.24f));
            _cropsPosition.Add(new Vector2(0.02f,-2.24f));
            _cropsPosition.Add(new Vector2(5.66f,-2.24f));
        }
        public void FirstSpawnPlot()
        {
            foreach (PlotModel plot in _plots)
            {
                GameObject _view = ObjectPool.Instance.GetFromPool<PlotView>("Plot");
                if (_view != null)
                {
                    _view.transform.position = new Vector3(_cropsPosition[plot.PlotId].x,_cropsPosition[plot.PlotId].y);
                    plot.ObjectView = _view;
                }
            }
        }
        public int GetPlotIdFromPosition(Vector3 pos)
        {
            foreach (PlotModel plot in _plots)
            {
                if (plot.ObjectView != null)
                {
                    if (plot.ObjectView.transform.position == pos)
                    {
                        return plot.PlotId;
                    }
                }
            }
            return -1;
        }
    }
}


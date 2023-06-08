using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyFarm
{
    public class StrawberrySeed : Seed
    {
        public StrawberrySeed(int amount = 0)
        {
            SeedName = "Strawberry Seed";
            CropCycleTime = 60 * 5;
            ProductCycleAmount = 1;
            MaxCrops = 20;
            _amount = amount;
        }
    }

}

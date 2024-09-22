using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HangingBridge
{

    [System.Serializable]
    public class BridgeTemplates
    {
        // Each column contains 8 rows of bridge tiles
        public BridgeTile[] rows = new BridgeTile[6];
    }

    [System.Serializable]
    public class BridgeTile
    {
        // Each row contains 4 tiles with boolean values
        public List<bool> tile;
    }
}
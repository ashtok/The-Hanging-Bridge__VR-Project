using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;
namespace HangingBridge
{
    public class BridgeHandler : MonoBehaviour
    {
        public List<BridgeTemplates> SampleBridges = new List<BridgeTemplates>(5);
        public List<BridgeRow> BridgeReference = new List<BridgeRow>();

        int rand;

        private void Awake()
        {
            rand = (int)(Random.Range(0f, 4f));     //Random Number in Range

        }

        private void Start()
        {
            Debug.Log($"Random Number is the Bridge puzzle Number == {rand}");
            if (GameManager.instance.isReloaded)
            {
                InitializeBridge(GameManager.instance.activeBridgeTemplate);        //Initialize Bridge template if Game is reloaded
            }
            else
            {
                InitializeBridge(rand);                //Initialize Bridge Template according to Random Number
            }            
        }

        private void Update()
        {
            TestBridge();

            if (Input.GetKeyDown(KeyCode.S))
            {
                ShowColorCoding();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                HideColorCoding();
            }
        }

        /// <summary>
        /// Initialize Bridge as per the Bridge Templates List
        /// </summary>
        /// <param name="bridgeTemplateCount">a Number that informs the method to load a certaain template into the main bridge</param>
        public void InitializeBridge(int bridgeTemplateCount)
        {
            Debug.Log($"Initializing Bridge according to random value {bridgeTemplateCount}");

            // Ensure that the given bridge template count is within the valid range
            if (bridgeTemplateCount >= 0 && bridgeTemplateCount < SampleBridges.Count)
            {
                // Loop through each row in BridgeReference
                for (int i = 0; i < BridgeReference.Count; i++)
                {
                    // Ensure that the given bridge template count is within the valid range
                    if (i < SampleBridges[bridgeTemplateCount].rows.Length)
                    {
                        // Loop through each tile in the row
                        for (int j = 0; j < BridgeReference[i].tile.Count; j++)
                        {
                            // Set the setActive value based on the boolean value in the corresponding BridgeTile
                            BridgeReference[i].tile[j].SetSafety(!(SampleBridges[bridgeTemplateCount].rows[i].tile[j]));
                            BridgeReference[i].tile[j].SetOriginalColor(BridgeReference[i].tile[j].tileRef.GetComponent<Renderer>().material.color);

                        }
                    }
                }
            }
            else
            {
                Debug.LogError("Invalid bridge template count.");
            }
            GameManager.instance.SetActiveBridgeTemplate(bridgeTemplateCount);
        }

        /// <summary>
        /// Tests the Plank the player is on. If the plank is not safe it disappers.
        /// </summary>
        public void TestBridge()
        {
            foreach (var row in BridgeReference)
            {
                foreach (var tile in row.tile)
                {
                    bool isTileSafe = tile.isSafe;
                    bool checkPlayerCollision = tile.tileRef.GetComponent<PlankCollisionChecker>().isColliding();
                    if (checkPlayerCollision && !isTileSafe)
                    {
                        Debug.Log("The tile is about to break");
                        StartCoroutine(DisableTile(tile.tileRef));
                    }

                }
            }
        }
        /// <summary>
        /// Method to disable a plank  
        /// </summary>
        /// <param name="obj">Takes gameobject reference of the plank</param>
        /// <returns></returns>
        IEnumerator DisableTile(GameObject obj)
        {
            yield return new WaitForSeconds(0.5f);
            obj.SetActive(false);
        }

        /// <summary>
        /// Shows the color of the planks based on their isSafe value
        /// </summary>
        public void ShowColorCoding()
        {
            int count = 0;
            foreach (var row in BridgeReference)
            {
                count++;
                foreach (var tile in row.tile)
                {
                    tile.tileRef.GetComponent<Renderer>().material.color = tile.isSafe ? tile.GetSafeColor() : tile.GetDangerColor();
                    //Debug.Log($"Inside this method??? for tile {tile} for row {row} count {count}");           
                }
            }
        }
        /// <summary>
        /// Hides color coding of the plank
        /// </summary>
        public void HideColorCoding()
        {
            foreach (var row in BridgeReference)
            {
                foreach (var tile in row.tile)
                {
                    tile.tileRef.GetComponent<Renderer>().material.color = tile.GetOriginalColor();
                }
            }
        }

    }


    /// <summary>
    /// Class for each row of the Bridge
    /// </summary>
    [System.Serializable]
    public class BridgeRow
    {
        // Each row contains 3 tiles with boolean values
        public List<BridgePlank> tile;
    }
}
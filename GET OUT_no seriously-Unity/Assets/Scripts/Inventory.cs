/**** 
 * Created by: Betzaida Ortiz Rivas
 * Date Created: March 2, 2022
 * 
 * Last Edited by: N/A
 * Last Edited:
 * 
 * Description: Updated the players inventory
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory")]

public class Inventory : ScriptableObject
{
    public string ID; //ref item easily
    public string displayName; 
    public Sprite icon;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

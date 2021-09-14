using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int camp;
    public int playerId;
    public int gold;
    public GameObject gameManager;

    GameSetting gameSetting;

    List<GameObject> units = new List<GameObject>();
    List<GameObject> buildings = new List<GameObject>();

    void Start()
    {
        gameSetting = gameManager.GetComponent<GameSetting>();
        GameObject barrack = Instantiate(gameSetting.BuildingPrefabs[camp, (int)Building.Barracks], transform);
        buildings.Add(barrack);
    }

    void Update()
    {
        if (playerId > 0) return;
        if(Input.GetKeyDown(KeyCode.A))
        {
            
            GameObject infantry = Instantiate(gameSetting.UnitPrefabs[camp, (int)Unit.Infantry], new Vector3(transform.position.x, transform.position.y, transform.position.z + 15.0f), new Quaternion());
            infantry.GetComponent<UnitManager>().init(playerId);
            units.Add(infantry);
        }
    }
}

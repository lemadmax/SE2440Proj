using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public float width;
    public float length;
    public float health;
    public float maxHealth;

    public GameObject healthBar;

    Building type;

    Vector3 spawnLoc;

    LineRenderer line;
    int segments = 50;
    float radius = 2.5f;

    void init(Building _type)
    {
        type = _type;
    }
    void Start()
    {
        spawnLoc = transform.position;
        spawnLoc.z += width;
        spawnLoc.y += length;

        line = gameObject.GetComponent<LineRenderer>();
        line.positionCount = segments + 1;
        line.useWorldSpace = false;
        line.startColor = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        line.endColor = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        line.startWidth = 0.3f;
        line.endWidth = 0.3f;
        line.transform.localPosition.Set(0.0f, 0.2f, 0.0f);
        radius = Mathf.Sqrt(width * width + length * length) / 2;
        CreatePoints();
        line.enabled = false;
    }
    void Update()
    {
        healthBar.GetComponent<HealthBarManager>().SetBar(new Vector3(health / maxHealth, 1.0f, 1.0f));
    }
    void CreatePoints()
    {
        float x;
        float z;
        float angle = 20f;
        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
            z = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
            line.SetPosition(i, new Vector3(x, 0.1f, z));
            angle += (360f / segments);
        }
    }
    public Vector3 GetSpawnLoc()
    {
        return spawnLoc;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public float block_x = 10.0f;
    public float block_y = 8.0f;
    // Start is called before the first frame update
    [SerializeField]　Block blockPrefab;
    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Spawn();
            block_y -= 4f;

        }
        for(int i2 =0; i2 < 5; i2++)
        {
            Spawn();
            block_x -= 4f;
        }
    }

    //カードの生成
    public void Spawn()
    {
        Instantiate(blockPrefab,new Vector2(block_x,block_y), Quaternion.identity);
    }
}

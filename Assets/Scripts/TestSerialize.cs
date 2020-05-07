using UnityEngine;

public class TestSerialize : MonoBehaviour
{
    public PlayerData player;

    void Start()
    {
        //創建玩家資料
        player = new PlayerData()
        {
            level = 1,
            hp = 100
        };
        Debug.Log($"玩家等級:{player.level} \n玩家血量{player.hp}");
    }

    void Update()
    {
        //按下A鍵可以扣血
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.hp -= 10;
            Debug.Log($"玩家受到了10點傷害 HP剩餘{player.hp}點");
        }
        //按下S鍵可以序列化
        if (Input.GetKeyDown(KeyCode.S))
        {
            DoSerialize();
        }
    }

    //序列化後由Log輸出
    private void DoSerialize()
    {
        var json = JsonUtility.ToJson(player);
        Debug.Log(json);
    }

}

//玩家類保存玩家資料
public class PlayerData
{
    public int level;//玩家的等級
    public int hp;//玩家的生命值
}

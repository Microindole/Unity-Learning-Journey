using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // 公开一个变量，可以在 Unity 编辑器里直接调整玩家的移动速度
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // 1. 获取玩家的输入
        // Input.GetAxis("Horizontal") 会获取 A/D 键或左右方向键的输入 (-1 到 1)
        float horizontalInput = Input.GetAxis("Horizontal");
        // Input.GetAxis("Vertical") 会获取 W/S 键或上下方向键的输入 (-1 到 1)
        float verticalInput = Input.GetAxis("Vertical");

        // 2. 创建一个移动方向的向量
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);

        // 3. 移动玩家
        // transform.Translate 让物体朝某个方向移动
        // Time.deltaTime 保证在不同帧率的电脑上，玩家的实际移动速度是一致的
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
    }
}
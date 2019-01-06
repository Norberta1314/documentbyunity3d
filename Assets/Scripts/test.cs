using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class test : MonoBehaviour
{
     //人物状态
    public const int HERO_UP = 0;  
    public const int HERO_RIGHT = 1;  
    public const int HERO_DOWN = 2;  
    public const int HERO_LEFT = 3;
    
    public Rigidbody rb;
  
    //人物当前行走的方向状态  
    public int state = 0;  
    //人物移动速度  
    public float moveSpeed = 2;  
      
    //初始化人物位置  
    public void Awake()  
    {  
        state = HERO_UP;
    }  
    // Use this for initialization  
    void Start ()
    {
       rb = GetComponent<Rigidbody>();
    }  
      
    // Update is called once per frame  
    void Update () {  
        //获取控制的方向， 上下左右，   
        
        float KeyVertical = Input.GetAxis("Vertical");  
        float KeyHorizontal = Input.GetAxis("Horizontal");  
        
        if(KeyVertical == -1)  
        {  
            setHeroState(HERO_DOWN); //下 
        }  
        else if(KeyVertical == 1)  
        {  
            setHeroState(HERO_UP);  //上
        }  
        if(KeyHorizontal == 1)  
        {  
            setHeroState(HERO_RIGHT); //右 
        }  
        else if(KeyHorizontal == -1)  
        {  
            setHeroState(HERO_LEFT);  //左
        } 
    }  
      
    void setHeroState(int newState)  
    {  
        //根据当前人物方向与上一次备份的方向计算出模型旋转的角度  
        int rotateValue = (newState - state) * 90;  
        Vector3 transformValue = new Vector3();  
            
        //模型移动的位置数值  
        switch(newState)  
        {  
        case HERO_UP:  
            transformValue = Vector3.forward * Time.deltaTime;  
            break;  
        case HERO_DOWN:  
            transformValue = (-Vector3.forward) * Time.deltaTime;  
            break;  
        case HERO_LEFT:  
            transformValue = Vector3.left * Time.deltaTime;  
            break;  
        case HERO_RIGHT:  
            transformValue = (-Vector3.left) * Time.deltaTime;  
            break;  
        }  
          
        
        transform.Rotate(Vector3.up, rotateValue);  
        //移动人物  
        transform.Translate(transformValue * moveSpeed, Space.World);
//        transform.Rigibody.MovePosition(transformValue * moveSpeed, Space.World);
        state = newState;  
    }

    private void OnCollisionEnter(Collision other)
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, 0);
    }
}

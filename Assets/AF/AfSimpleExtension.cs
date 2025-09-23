using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/** AfSimpleExtension : Unity扩展插件
 * 
 *  作者：邵发
 *  官网：https://afanihao.cn
 *  
 *  本插件是【Unity3D入门教程】的配套插件，最新版本在课程网盘中获取！
 *  
 *  更新日志：
 *  - 2021-12-24 
 *  
 */

public class AfSimpleExtension : Editor
{
    static Quaternion lastRotation;
    //static int view = 0; // 当前视角

    /** 打印日志
     * 
    */
    static void ShowLog(string message)
    {
        string time = DateTime.Now.ToString("HH:mm"); ;
        time = "[ " + time + " ] - ";

        Debug.Log(time + message);
    }

    [MenuItem("AF/正交顶视图 _1" , false , 100)]
    static void ISO_TopView()
    {
        SceneView view = SceneView.lastActiveSceneView;

        if (!view.orthographic)
        {
            ISO_View( new Vector3(90, 0, 0));
            ShowLog("正交顶视图");
        }
        else
        {
            Persp_View();
        }
    }

    [MenuItem("AF/正交后视图 _2", false, 100)]
    static void ISO_BackView()
    {
        SceneView view = SceneView.lastActiveSceneView;

        if (!view.orthographic)
        {
            ISO_View(new Vector3(0, 0, 0));
            ShowLog("正交后视图");
        }
        else
        {
            Persp_View();
        }
    }

    [MenuItem("AF/正交右视图 _3" , false, 100)]
    static void ISO_RightView()
    {
        SceneView view = SceneView.lastActiveSceneView;

        if (!view.orthographic)
        {
            ISO_View(new Vector3(0, -90, 0));
            ShowLog("正交右视图");
        }
        else
        {
            Persp_View();           
        }
    }
        

    static void ISO_View( Vector3 angle )
    {
        SceneView view = SceneView.lastActiveSceneView;
        view.orthographic = true;
        lastRotation = view.rotation;
        view.rotation = Quaternion.Euler(angle);
        
    }

    [MenuItem("AF/透视图 _0", false, 100)]
    static void Persp_View()
    {
        SceneView view = SceneView.lastActiveSceneView;
        view.orthographic = false;
        view.rotation = lastRotation;
        ShowLog("透视图");
    }

    [MenuItem("AF/置于视置中心 _G", false, 200)]
    static void FocusAtObject()
    {
        GameObject obj = Selection.activeGameObject;
        if (obj == null)
        {
            ShowLog("Warn: 当前没有选中物体!");
            return;
        }

        SceneView view = SceneView.lastActiveSceneView;
        view.pivot = obj.transform.position;
    }

    //[MenuItem("AF/删除选中物体 _X" , false, 200)]
    //static void DeleteSelectObjects()
    //{
    //    GameObject[] objs = Selection.gameObjects;

    //    foreach ( GameObject obj in objs)
    //    {
    //        DestroyImmediate(obj);
    //    }

    //    ShowLog("删除了 " + objs.Length + " 个物体");
    //}
         


    [MenuItem("AF/物体测距 ", false, 300)]
    static void GetDistanceOfObject()
    {
        GameObject[] objs = Selection.gameObjects;
        if(objs.Length > 2)
        {
            ShowLog("Warn: 请只选择2个物体，不要选择太多物体!");
            return;
        }
        if(objs.Length != 2)
        {
            ShowLog("Warn: 请先选择2个物体，然后再执行测量！");
            return;
        }


        float distance = (objs[0].transform.position - objs[1].transform.position).magnitude;

        ShowLog("距离为: " + distance + ", " + objs[0].name + " -> " + objs[1].name);

    }

    [MenuItem("AF/模型尺寸 ", false, 300)]
    static void GetMeshDimension()
    {
        GameObject obj = Selection.activeGameObject;
        if (obj == null)
        {
            ShowLog("Warn: 当前没有选中物体!");
            return;
        }

        MeshRenderer renderer = obj.GetComponent<MeshRenderer>();
        if (renderer == null)
        {
            ShowLog("Warn: 当前物体没有网格，缺少MeshRenderer组件 !");
            return;
        }
        Vector3 size = renderer.bounds.size;

        ShowLog("物体: " + obj.name + "  尺寸: " + size.ToString("F2"));

    }





   
}

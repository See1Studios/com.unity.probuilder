﻿using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using ProBuilder2.Common;
using ProBuilder2.MeshOperations;
using System.Linq;

using TMesh = TriangleNet.Mesh;
using UMesh = UnityEngine.Mesh;
using TriangleNet;
using TriangleNet.Data;
using TriangleNet.Geometry;

public class TempMenuItems : EditorWindow
{
	[MenuItem("Tools/Temp Menu Item &d")]
	static void MenuInit()
	{
		EditorWindow.GetWindow<TempMenuItems>().ShowUtility();
	}

	EventModifiers em = EventModifiers.None;

	void OnGUI()
	{
		em = (EventModifiers) EditorGUILayout.EnumMaskField(em);

		GUILayout.Label(em.ToString() +  " : " + (int) em);
	}

	// 	List<pb_Shortcut> shortcuts = pb_Shortcut.DefaultShortcuts().ToList();
	// 	Debug.Log(shortcuts.ToString("\n"));


	// 	const int VERTEX_COUNT = 4;
	// 	Vector2[] v = new Vector2[VERTEX_COUNT]
	// 	{
	// 		new Vector2(.5f, -.5f),
	// 		new Vector2(.5f,  0f),
	// 		new Vector2(1f, -.5f),
	// 		new Vector2(1f, 0f),
	// 	};

	// 	// for(int i = 0; i < v.Length; i++)
	// 	// 	v[i] = new Vector2( Random.Range(-10f, 10f), Random.Range(-10f, 10f) );

	// 	Vector2[] v2 = pb_Math.Sort(v).ToArray();

	// 	List<int> indices;
	// 	if(! pb_Triangulation.Triangulate(v2, out indices, true) )
	// 	{
	// 		Debug.LogError("Failed triangulation!");
	// 		return;
	// 	}
	
	// 	UMesh m = new UMesh();
	// 	m.vertices = v2.Select(x=>(Vector3)x).ToArray();
	// 	m.uv = v2;
	// 	m.triangles = indices.ToArray();
	// 	m.normals = pbUtil.Fill<Vector3>(-Vector3.forward, VERTEX_COUNT);

	// 	GameObject go = new GameObject();
	// 	go.AddComponent<MeshFilter>().sharedMesh = m;
	// 	go.AddComponent<MeshRenderer>().sharedMaterial = pb_Constant.DefaultMaterial;
	// }

}

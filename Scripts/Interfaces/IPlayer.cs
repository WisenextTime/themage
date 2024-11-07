﻿using Godot;

namespace TheMage.Scripts.Interfaces;

public interface IPlayer
{
	public Vector3 GetGlobalPosition();
	public Vector3 GetGlobalDirection();
	public SceneTree GetTree();
	public Node GetNode(NodePath path);
	public Node3D GetObjects();
	Vector2 GetDirection();
	
	Vector3 ToLocal(Vector3 vector);
}
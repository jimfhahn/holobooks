﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holobook.WebRequest;
using System;
using System.Diagnostics;
using Configuration;

public class testScript : MonoBehaviour {

	// Use this for initialization
	void Start () {


		Utils.runScript(Config.PythonPath(),"downloadBook.sh");





	}





}

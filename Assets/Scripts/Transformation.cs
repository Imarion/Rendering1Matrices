using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;

public abstract class Transformation : MonoBehaviour {

	public abstract Vector3 Apply (Vector3 point);

}

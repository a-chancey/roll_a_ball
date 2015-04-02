/*
	SetRenderQueue.cs
 
	Sets the RenderQueue of an object's materials on Awake. This will instance
	the materials, so the script won't interfere with other renderers that
	reference the same materials.
*/

using UnityEngine;

[AddComponentMenu("Rendering/SetRenderQueue")]

public class SetRenderQueue : MonoBehaviour {
	
	[SerializeField]
	protected int[] m_queues = new int[]{3020};
	protected int[] m_queues2 = new int[]{2000};
	protected int m_queue = new int();
	protected void Awake() {
		m_queue = 3000;
		}
	public void OnTriggerStay (Collider other) {
		if(other.gameObject.tag == "Occlusion") {
			Material[] materials = GetComponent<Renderer>().materials;
			for (int i = 0; i < materials.Length && i < m_queues.Length; ++i) {
			materials[i].renderQueue = m_queues[i];
				materials[i].SetFloat("_Mode", 1.0f);
			}
		}
	}
	void OnTriggerExit (Collider other) {
		if(other.gameObject.tag == "Occlusion") {
			print("exit") ;
			Material[] materials = GetComponent<Renderer>().materials;
			for (int i = 0; i < materials.Length && i < m_queues.Length; ++i) {
				materials[0].renderQueue = m_queues2[0];
				materials[0].SetFloat("_Mode", 0.0f);

		}
	}
}
}
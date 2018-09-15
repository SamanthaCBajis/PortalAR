using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.iOS{ //access to ARKit namespace (plugin) for function
								//function to rectify glitches from walking into portal
public class PortalController : MonoBehaviour {

    public Material[] materials; //material array, where all materials will be dragged in to be on other side of portal
        public MeshRenderer meshRenderer; //mesh renderer reference
        public UnityARVideo UnityARVideo; //ARVideo reference

        private bool isInside = false;
        private bool isOutside = true;


	// Use this for initialization
	void Start () {
            OutsidePortal();
		
	}
        void OnTriggerStay(Collider col)
        {
            Vector3 playerPos = Camera.main.transform.position +
                                      Camera.main.transform.forward * (Camera.main.nearClipPlane * 4);
            if (transform.InverseTransformPoint(playerPos).z <= 0){
                if (isOutside){
                    isOutside = false;
                    isInside = true;
                    InsidePortal();
                }

            }else{
                if(isInside){
                    isInside = false;
                    isOutside = true;
                    OutsidePortal();
                }
            }
        }
        void OutsidePortal(){
            StartCoroutine(DelayChangeMat(3));
        }

        void InsidePortal()
        {
            StartCoroutine(DelayChangeMat(6));
        }

        IEnumerator DelayChangeMat(int stencilNum){
            UnityARVideo.shouldRender = false;
            meshRenderer.enabled = false;
            foreach (Material mat in materials){
                mat.SetInt("_Stencil", stencilNum);
            }

            yield return new WaitForEndOfFrame();
            meshRenderer.enabled = true;
            UnityARVideo.shouldRender = true;
        }
		
	}
}

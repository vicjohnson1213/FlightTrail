using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFMF;
using UnityEngine;

namespace FlightTrail
{
    public class SuperflightTrail: IMod
    {
        private TrailRenderer trail;
        private GameObject player;
        private GameObject camera;
        private GameObject loc = new GameObject();


        void Start()
        {
            player = LocalGameManager.Singleton.playerPrefab;
            camera = LocalGameManager.Singleton.playerCamManager.mainCamera.mainCameraReference.gameObject;
            trail = camera.gameObject.AddComponent(typeof(TrailRenderer)) as TrailRenderer;
            //float alpha = 1.0f;
            //Gradient gradient = new Gradient();
            //gradient.SetKeys(
            //    new GradientColorKey[] { new GradientColorKey(Color.green, 0.0f), new GradientColorKey(Color.red, 1.0f) },
            //    new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
            //    );
            //trail.colorGradient = gradient;
            trail.startColor = new Color(1, 1, 1, 0);
            trail.endColor = new Color(1, 1, 1, 1);
            trail.time = Mathf.Infinity;
            trail.startWidth = 0.5f;
        }

        public void Update()
        {
            Cursor.visible = true;
        }
    }
}

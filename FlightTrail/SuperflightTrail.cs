using SFMF;
using UnityEngine;

namespace FlightTrail
{
    public class SuperflightTrail: IMod
    {
        private TrailRenderer trail;
        private GameObject camera;

        private int? currentSeed;

        void Start()
        {
            camera = LocalGameManager.Singleton.playerCamManager.mainCamera.mainCameraReference.gameObject;
            trail = camera.gameObject.AddComponent<TrailRenderer>();
            trail.time = Mathf.Infinity;

            var mat = new Material(Shader.Find("Diffuse"));

            trail.material = mat;
            trail.material.color = Color.red;

            currentSeed = WorldManager.currentWorld.seed;
        }

        public void Update()
        {
            var isNextWorld = currentSeed != null && (currentSeed.Value != WorldManager.currentWorld.seed);

            if (isNextWorld || Input.GetKeyDown(KeyCode.JoystickButton1))
            {
                trail.Clear();
            }

            currentSeed = WorldManager.currentWorld.seed;
        }
    }
}

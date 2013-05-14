using UnityEngine;
using System.Collections.Generic;

	public class SkylineManager : MonoBehaviour
	{
        public Transform prefab;
        public int numberOfObjects;
        public float recycleOffset;
        public Vector3 minSize, maxSize;
            //, minDist, maxDist;

        private Vector3 nextPosition;
        private Queue<Transform> objectQueue;

        void Start() 
        {
            StartGame.GameStart += GameStart;
            StartGame.GameOver += GameOver;

            objectQueue = new Queue<Transform>(numberOfObjects);
            for (int i = 0; i < numberOfObjects; i++)
            {
                objectQueue.Enqueue((Transform)Instantiate(prefab, new Vector3 (0f,0f,-100f), Quaternion.identity));
            }
                       nextPosition = transform.localPosition;
                       for (int i = 0; i < numberOfObjects; i++)
                       {
                           Recycle();
                       }
        }

        void Update()
        {
            if (objectQueue.Peek().localPosition.y + recycleOffset < LevelScroll.distanceTraveled)
            {
                Recycle();   
            
            }



        }

        private void Recycle()
        {
            Vector3 scale = new Vector3(Random.Range(minSize.x, maxSize.x), Random.Range(minSize.y, maxSize.y), Random.Range(minSize.z, maxSize.z));
            //Vector3 position = new Vector3(Random.Range(minDist.x, maxDist.x), Random.Range(minDist.y, maxDist.y), Random.Range(minDist.z, maxDist.z));
            Vector3 position = nextPosition;
            position.x += scale.x * .5f;
            position.y += scale.y * .5f;

            Transform o = objectQueue.Dequeue();
            o.localPosition = position;
            o.localScale = scale;
            nextPosition.y +=scale.y;
            objectQueue.Enqueue(o);
        
        
        }

        private void GameStart()
        {
            nextPosition = transform.localPosition;
            for (int i = 0; i < numberOfObjects; i++)
            {
                Recycle();
            
            }
            enabled = true;
        
        }

        public void GameOver()
        {

            enabled = false;
        
        }


	}


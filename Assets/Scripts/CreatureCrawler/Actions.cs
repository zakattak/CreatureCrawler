using UnityEngine;

namespace CreatureCrawler {
    public class Actions : MonoBehaviour {

        private State _state;

        public void Awake() {
            Debug.Log("Actions component is awake.");
        }

        public void Start() {
            _state = GetComponent<State>();
            Debug.Log("Actions component is initialized.");
        }

        public void SpawnMon(
            Templates.MonTemplates monTemplate,
            string monName
        ) {
            var newMon = Templates.mons[monTemplate]();
            newMon.Name = monName;
            _state.mons.Add(newMon.Id, newMon);
        }
    }
}
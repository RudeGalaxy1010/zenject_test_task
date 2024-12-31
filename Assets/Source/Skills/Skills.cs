using System.Collections.Generic;

namespace Source.Skills {
    public class Skills : ISkills {
        private readonly List<string> _skills;

        public Skills() {
            _skills = new List<string>();
        }
    
        public Skills(List<string> skills) {
            if (skills == null || skills.Count == 0) {
                _skills = new List<string>();
                return;
            }
        
            _skills = skills;
        }

        public override string ToString() {
            string result = "";

            if (_skills.Count == 0) {
                return "\t-\n";
            }
        
            for (int i = 0; i < _skills.Count; i++) {
                result += $"\t[{i + 1}] {_skills[i]}\n";
            }

            return result;
        }

        public void Add(string skillName) {
            if (_skills.Contains(skillName)) {
                return;
            }
            
            _skills.Add(skillName);
        }
    }
}
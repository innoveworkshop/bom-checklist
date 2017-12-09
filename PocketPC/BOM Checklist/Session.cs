using System;
using System.Collections.Generic;
using System.Text;

namespace Production_Assistant {
	class Session {
		public Dictionary<string, string> ProjectInfo;
		public List<string> Categories;

		/**
		 * Session class constructor.
		 */
		public Session() {
			this.ProjectInfo = new Dictionary<string, string>();
			this.Categories = new List<string>();
		}

		public void AddProjectInfo(string name, string value) {
			this.ProjectInfo.Add(name, value);
		}
	}
}

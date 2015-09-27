using System.Collections.Generic;

using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

using OpenQA.Selenium;

namespace Bumblebee.Examples.Web.Pages.Nirvana
{
	//public class TaskList : SpecificBlock
    public class TaskList : Block
	{
		//public TaskList(Session session, IWebElement tag) : base(session, tag)
        public TaskList(IBlock parent, By by)
            : base(parent, by)
		{
		}

		public string Name
		{
			//get { return GetElement(By.ClassName("name")).Text; }
            get { return FindElement(By.ClassName("name")).Text; }
		}

		public IEnumerable<TaskRow> TaskRows
		{
			get
			{
				//return GetElement(By.ClassName("tasks"))
					//.GetElements(By.ClassName("task"))
					//.Select(tag => new TaskRow(Session, tag));

			    return new BlockEnumerable<TaskRow>(this, By.CssSelector(".tasks > .task"));
			}
		}
	}
}

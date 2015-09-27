using System.Collections.Generic;
using System.Linq;

using Bumblebee.Implementation;
using Bumblebee.Setup;

using OpenQA.Selenium;

namespace Bumblebee.Examples.Web.Pages.Nirvana
{
	//public class MainArea : WebBlock

    public class MainArea : Block
    {
		//public MainArea(Session session) : base(session)
        public MainArea(Session session)
            : base(session, By.Id("main"))
		{
			//Tag = GetElement(By.Id("main"));
		}

		public IEnumerable<TaskList> TaskLists
		{
			get
			{
			    //return GetElements(By.ClassName("tasklist"))
			    //	.Select(x => new TaskList(Session, x));
                return new BlockEnumerable<TaskList>(this, By.ClassName("tasklist"));
			}
		}
	}
}

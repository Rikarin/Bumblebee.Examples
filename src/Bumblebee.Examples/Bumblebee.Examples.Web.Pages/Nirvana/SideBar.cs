using Bumblebee.Implementation;
using Bumblebee.Setup;

using OpenQA.Selenium;

namespace Bumblebee.Examples.Web.Pages.Nirvana
{
	//public class SideBar : WebBlock
    public class SideBar : Block
	{
		public SideBar(Session session) : base(session, By.Id("east"))
		{
			//Tag = GetElement(By.Id("east"));
		}

		public IWebElement Trash
		{
			//get { return GetElement(By.ClassName("trash")); }
            get { return FindElement(By.ClassName("trash")); }
		}
	}
}

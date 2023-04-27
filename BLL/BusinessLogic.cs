using System.Runtime.CompilerServices;

// todo-other look at https://github.com/thomaslevesque/InternalsVisibleTo.MSBuild/blob/master/README.md
[assembly: InternalsVisibleTo("AdminApp.BLL.Tests")]

namespace AdminApp.BLL;

// todo-maintability what is the purpose of this class? 
internal class BusinessLogic
{
}
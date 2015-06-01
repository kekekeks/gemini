using System.Threading.Tasks;
using TaskSupport;

namespace Gemini.Framework.Threading
{
    public class TaskUtility
    {
        public static readonly Task Completed = TaskUtil.FromResult(true);
    }
}
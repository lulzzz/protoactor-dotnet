using System.Threading.Tasks;
namespace Proto.ActorExtensions.Tests
{
    public class SampleActor : IActor
    {
        public static bool Created = false;

        public SampleActor()
        {
            Created = true;
        }

        public Task ReceiveAsync(IContext context)
        {
            return Actor.Done;
        }
    }
}
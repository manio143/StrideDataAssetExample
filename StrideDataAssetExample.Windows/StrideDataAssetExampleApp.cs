using Stride.Engine;

namespace StrideDataAssetExample
{
    class StrideDataAssetExampleApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}

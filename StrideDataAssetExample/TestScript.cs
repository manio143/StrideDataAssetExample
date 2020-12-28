using Stride.Core.Assets;
using Stride.Core.Mathematics;
using Stride.Engine;
using System;

namespace StrideDataAssetExample
{
    public class TestScript : SyncScript
    {
        public CustomDataAsset CustomDataAsset { get; set; }
        public Data<SimpleDataAsset> SimpleData { get; set; }

        private int i = 0;
        private TimeSpan lastColorChange;

        public override void Update()
        {
            var deltaTime = Game.UpdateTime.Total - lastColorChange;
            if (deltaTime.TotalSeconds > 2)
            {
                lastColorChange = Game.UpdateTime.Total;
                i = (i + 1) % CustomDataAsset.Values.Length;
            }

            var color = new Color4(CustomDataAsset.Values[i]);

            DebugText.Print(
                $"Custom data asset example.\n" +
                $"Color value: {CustomDataAsset.Values[i]} - ({Math.Round(color[0]*255)}, {Math.Round(color[1]*255)}, {Math.Round(color[2]*255)}, {Math.Round(color[3]*255)})\n" +
                $"SimpleData.MyText: {SimpleData.Value.MyText}\n" +
                $"SimpleData.MyNumber: {SimpleData.Value.MyNumber}",
                new Int2(20),
                color);
        }
    }
}

using Stride.Core;
using Stride.Core.Assets;
using Stride.Core.Serialization;
using Stride.Core.Serialization.Contents;

namespace StrideDataAssetExample
{
    // Usually you don't need all that jazz that comes into creating a custom data asset.
    // So you can use a simplified instance of IData<TSelf> and in your code refer to Data<T>
    // to use this class as an asset reference.
    // There's a default converter implemented for Data<T> and you can leave it empty in the editor.
    [DataContract] // generate default serializer
    // Register reference serializer for instances of Data<T>
    [DataSerializerGlobal(typeof(ReferenceSerializer<Data<SimpleDataAsset>>), Profile = "Content")]
    public class SimpleDataAsset : IData<SimpleDataAsset>
    {
        public string MyText { get; set; }
        public int MyNumber { get; set; }
    }
}

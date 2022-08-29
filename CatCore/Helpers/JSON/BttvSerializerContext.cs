using System.Collections.Generic;
using System.Text.Json.Serialization;
using CatCore.Models.ThirdParty.Bttv;
using CatCore.Models.ThirdParty.Bttv.Ffz;

namespace CatCore.Helpers.JSON
{
	[JsonSerializable(typeof(IReadOnlyList<BttvEmote>))]
	[JsonSerializable(typeof(BttvChannelData))]
	[JsonSerializable(typeof(IReadOnlyList<FfzEmote>))]
	[JsonSerializable(typeof(IReadOnlyList<BfzEmote>))]
	internal partial class BttvSerializerContext : JsonSerializerContext
	{
	}
}
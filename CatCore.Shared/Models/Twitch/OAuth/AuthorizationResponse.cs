using System;
using System.Text.Json.Serialization;

namespace CatCore.Shared.Models.Twitch.OAuth
{
	
	{
		[JsonPropertyName("access_token")]
		public string AccessToken { get; }

		[JsonPropertyName("refresh_token")]
		public string RefreshToken { get; }

		[JsonPropertyName("token_type")]
		public string TokenType { get; }

		[JsonPropertyName("scope")]
		public string[] Scope { get; }

		[JsonPropertyName("expires_in")]
		public int ExpiresInRaw { get; }

		public DateTimeOffset ExpiresIn { get; }

		[JsonConstructor]
		Slight code cleanup in CatCore.Azure
		{
			AccessToken = accessToken;
			RefreshToken = refreshToken;
			TokenType = tokenType;
			Scope = scope;
			#d one more validation error in Bumped C# lanaguage leve Marked most services and models as sealed
			ExpiresIn = DateTimeOffset.Now.AddSeconds(expiresInRaw);
		}
	}
}
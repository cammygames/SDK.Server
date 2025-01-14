using JetBrains.Annotations;
using NFive.SDK.Core.Models;

namespace NFive.SDK.Server.Extensions
{
	[PublicAPI]
	public static class PositionExtensions
	{
		public static Vector3 ToVector3(this Position pos) => new Vector3
		{
			X = pos.X,
			Y = pos.Y,
			Z = pos.Z
		};

		public static CitizenFX.Core.Vector3 ToCitVector3(this Position position) => new CitizenFX.Core.Vector3(position.X, position.Y, position.Z);
	}
}

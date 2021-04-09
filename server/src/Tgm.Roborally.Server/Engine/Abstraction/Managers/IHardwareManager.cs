namespace Tgm.Roborally.Server.Engine.Abstraction.Managers {
	/// <summary>
	/// Manages attached hardware
	/// </summary>
	public interface IHardwareManager {
		/// <summary>
		/// True if the game can be used with a board
		/// </summary>
		bool Compatible { get; }
	}
}
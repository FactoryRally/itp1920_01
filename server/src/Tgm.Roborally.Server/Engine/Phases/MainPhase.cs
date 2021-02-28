using System;
using System.Collections.Generic;
using Tgm.Roborally.Server.Models;

namespace Tgm.Roborally.Server.Engine.Phases {
	public class MainPhase : GamePhase {
		protected override object Information => null;

		public override GameState NewState => GameState.PLAYING;

		protected override GamePhase Run(GameLogic game) {
			game.Map = new Map();
			game.Map[1, 1] = new Tile {
				Type = TileType.PrioCore
			};
			game.CommitEvent(new EmptyEvent(EventType.MapCreated));
			return new UpgradeShopPhase();
			//throw new System.NotImplementedException();
		}

		public override void Notify(ActionType action) => //TODO proper reaction
			Console.Out.WriteLine("Unexpected Action " + action + " in MainPhase");

		public override bool Notify(GenericEvent action) {
			bool allow = action.Type == EventType.MapCreated;
			if (!allow)
				Console.Out.WriteLine("Unexpected " + action.Data +
									  " Event in Main phase"); //TODO: proper implementation
			return allow;
		}

		public override IList<EntityEventOportunity> GetPossibleActions(int a, int b) =>
			new List<EntityEventOportunity>();
	}
}
using System;
using System.Collections.Generic;
using Tgm.Roborally.Server.Models;

namespace Tgm.Roborally.Server.Engine.Phases {
	public class PreExecutionPhase : GamePhase {
		protected override object Information => new ExecutionInfo(PostExecutionPhase.register);

		protected override GamePhase Run(GameLogic game) {
			return new PreStatementPhase();
		}

		public override GameState NewState => GameState.PLAYING;

		public override void Notify(ActionType action) { //TODO
		}

		public override bool Notify(GenericEvent action) => false;

		public override IList<EntityEventOportunity> GetPossibleActions(int robot, int player) => throw new NotImplementedException();
	}

	public class ExecutionInfo {
		public readonly int RegisterIndex;

		public ExecutionInfo(int registerIndex) {
			RegisterIndex = registerIndex;
		}
	}
}
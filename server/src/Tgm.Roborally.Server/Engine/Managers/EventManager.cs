using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Tgm.Roborally.Server.Engine {
	/// <summary>
	/// Handles event stacks and reacting. Each player has his own event Stack to consume from. Used to add/commit and consume events
	/// </summary>
	public class EventManager {
		private readonly GameLogic                     game;
		private readonly object                        locker = new object();
		/// <summary>
		/// The event queues for each player
		/// </summary>
		public           Dictionary<int, Queue<Event>> queues = new Dictionary<int, Queue<Event>>();

		public EventManager(GameLogic game) {
			this.game = game;
		}

		/// <summary>
		///     Adds the event to the stack and notifies waiting clients
		/// </summary>
		/// <param name="e"></param>
		public void Notify(Event e) {
			foreach (int player in game.PlayerIds) {
				if (!queues.ContainsKey(player))
					queues[player] = new Queue<Event>();
				queues[player].Enqueue(e);
			}

			if ( /*TODO: check for event consumer compatability*/true) {
				foreach ((int key, _) in game.Consumers) {
					if (!queues.ContainsKey(key))
						queues[key] = new Queue<Event>();
					queues[key].Enqueue(e);
				}
			}

			lock (locker) {
				Monitor.PulseAll(locker);
			}
		}

		/// <summary>
		///     Removes and recives the next event for this player
		/// </summary>
		/// <param name="player">the player to get the event for</param>
		/// <returns></returns>
		public Event Pop(int player) => queues[player].Count > 0 ? queues[player].Dequeue() : null;

		/// <summary>
		///     Wait for the next event
		/// </summary>
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void Await() {
			lock (locker) {
				Monitor.Wait(locker);
			}
		}

		/// <summary>
		/// Look at the next event for an specific player without popping it
		/// </summary>
		/// <param name="player">the player to get the next event for</param>
		/// <returns>the peeked event</returns>
		public Event Peek(int player) => queues[player].Count > 0 ? queues[player].Peek() : null;
	}
}
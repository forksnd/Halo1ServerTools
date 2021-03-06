/*
	Copyright (c) 2004 Cory Nelson

	Permission is hereby granted, free of charge, to any person obtaining
	a copy of this software and associated documentation files (the
	"Software"), to deal in the Software without restriction, including
	without limitation the rights to use, copy, modify, merge, publish,
	distribute, sublicense, and/or sell copies of the Software, and to
	permit persons to whom the Software is furnished to do so, subject to
	the following conditions:

	The above copyright notice and this permission notice shall be included
	in all copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
	EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
	MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
	IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
	CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
	TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
	SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System.Collections;
using GameStat;

namespace GameStat.Collections {
	/// <summary>
	/// A strongly typed collection for holding player information.
	/// </summary>
	public class PlayerCollection : System.Collections.CollectionBase {
		/// <summary>
		/// Adds an item to the PlayerCollection.
		/// </summary>
		/// <param name="value">The Player to add to the PlayerCollection</param>
		/// <returns>The position into which the new element was inserted.</returns>
		public int Add(Player value) {
			return base.List.Add(value);
		}

		/// <summary>
		/// Removes the first occurrence of a specific Player from the PlayerCollection.
		/// </summary>
		/// <param name="value">The Player to remove from the PlayerCollection</param>
		public void Remove(Player value) {
			base.List.Remove(value);
		}

		/// <summary>
		/// Inserts an item to the PlayerCollection at the specified position.
		/// </summary>
		/// <param name="index">The zero-based index at which value should be inserted.</param>
		/// <param name="value">The Player to insert into the PlayerCollection.</param>
		public void Insert(int index, Player value) {
			base.List.Insert(index, value);
		}

		/// <summary>
		/// Determines whether the PlayerCollection contains a specific value.
		/// </summary>
		/// <param name="value">The Player to locate in the PlayerCollection.</param>
		/// <returns>true if the Player is found in the PlayerCollection; otherwise, false.</returns>
		public bool Contains(Player value) {
			return base.List.Contains(value);
		}

		/// <summary>
		/// Gets or sets the element at the specified index.
		/// </summary>
		public Player this[int index] {
			get {
				return (Player)base.List[index];
			}
			set {
				base.List[index]=value;
			}
		}

		/// <summary>
		/// Creates a new instance of the PlayerCollection class.
		/// </summary>
		public PlayerCollection() {}
	}
}

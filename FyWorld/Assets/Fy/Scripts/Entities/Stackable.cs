/*
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
| FyWorld - A top down simulation game in a fantasy medieval world.    |
|                                                                      |
|    :copyright: © 2019 Florian Gasquez.                               |
|    :license: GPLv3, see LICENSE for more details.                    |
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
using System.Collections.Generic;
using UnityEngine;
using Fy.Definitions;
using Fy.Helpers;
using Fy.Visuals;

namespace Fy.Entities {
	/// Stackable tilable	
	public class Stackable : Tilable {
		public InventoryTilable inventory { get; protected set; }
		public StockArea area  { get; protected set; }

		public Stackable(Vector2Int position, TilableDef def, int count) {
			this.position = position;
			this.def = def;
			this.inventory = new InventoryTilable(this, count);
			this.mainGraphic = GraphicInstance.GetNew(this.def.graphics);
			this.area = null;

			Loki.stackableLabelController.AddLabel(this);
		}

		public Stackable(Vector2Int position, StockArea area) {
			this.position = position;
			this.def = Defs.empty;
			this.area = area;
			this.inventory = null;
			this.mainGraphic = GraphicInstance.GetNew(
				this.def.graphics, 
				this.area.color, 
				Res.TextureUnicolor(this.area.color),
				1
			);
			//Loki.stackableLabelController.AddLabel(this);
		}

		public void AddInventory() {
			
		}
	}
}
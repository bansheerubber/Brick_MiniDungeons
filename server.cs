exec("./damage.cs");
exec("./debris.cs");
exec("./board debris.cs");
exec("./boards.cs");
exec("./plant debris.cs");
exec("./plant.cs");
exec("./sounds.cs");
exec("./crate debris.cs");
exec("./crate.cs");
exec("./paintings.cs");
exec("./corpse.cs");
exec("./barrel.cs");
exec("./barrel debris.cs");
exec("./tower support.cs");
exec("./wall.cs");
exec("./floor.cs");
exec("./ceiling.cs");
exec("./sketch.cs");
exec("./stalagmites.cs");
exec("./stalactites.cs");
exec("./potion refill.cs");
exec("./shop.cs");

deActivatePackage(MiniDungeonsDoors);
package MiniDungeonsDoors {
	function fxDTSBrick::doorClose(%this, %client) {
		Parent::doorClose(%this, %client);

		%this.setColliding(true);
	}

	function fxDTSBrick::doorOpen(%this, %client) {
		Parent::doorOpen(%this, %client);

		%this.setColliding(false);
	}
};
activatePackage(MiniDungeonsDoors);
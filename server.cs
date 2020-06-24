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
exec("./sketch.cs");
exec("./wall.cs");
exec("./floor.cs");
exec("./ceiling.cs");

datablock AudioProfile(StalagmiteBreakSound) {
	filename    = "./sounds/stalagmite break.wav";
	description = AudioClose3d;
	preload = true;
};

datablock fxDTSBrickData(BrickStalagmite1Data) {
	brickFile = "./bricks/stalagmite1.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Stalagmite Cluster ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalagmite1";
	isWaterBrick = false;

	isBreakable = true;
};

function BrickStalagmite1Data::onBreak(%this, %obj) {
	(new Projectile() {
		datablock = Stalagmite1BrokenProjectile;
		initialPosition = %obj.getPosition();
		initialVelocity = "0 0 15";
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();
	%obj.setColliding(false);
	%obj.setDatablock(BrickStalagmite1BrokenData);
	serverPlay3dTimescale(StalagmiteBreakSound, %obj.getPosition(), getRandom(8, 12) / 10);
}

datablock fxDTSBrickData(BrickStalagmite2Data) {
	brickFile = "./bricks/stalagmite2.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Single Stalagmite, Large+Tall ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalagmite2";
	isWaterBrick = false;

	isBreakable = true;
};

function BrickStalagmite2Data::onBreak(%this, %obj) {
	(new Projectile() {
		datablock = Stalagmite2BrokenProjectile;
		initialPosition = %obj.getPosition();
		initialVelocity = "0 0 15";
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();
	%obj.setColliding(false);
	%obj.setDatablock(BrickStalagmite2BrokenData);
	serverPlay3dTimescale(StalagmiteBreakSound, %obj.getPosition(), getRandom(8, 12) / 10);
}

datablock fxDTSBrickData(BrickStalagmite3Data) {
	brickFile = "./bricks/stalagmite3.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Single Stalagmite, Large+Short ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalagmite3";
	isWaterBrick = false;

	isBreakable = true;
};

function BrickStalagmite3Data::onBreak(%this, %obj) {
	(new Projectile() {
		datablock = Stalagmite3BrokenProjectile;
		initialPosition = %obj.getPosition();
		initialVelocity = "0 0 15";
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();
	%obj.setColliding(false);
	%obj.setDatablock(BrickStalagmite3BrokenData);
	serverPlay3dTimescale(StalagmiteBreakSound, %obj.getPosition(), getRandom(8, 12) / 10);
}

datablock fxDTSBrickData(BrickStalagmite5Data) {
	brickFile = "./bricks/stalagmite5.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Single Stalagmite, Small+Tall ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalagmite5";
	isWaterBrick = false;

	isBreakable = true;
};

function BrickStalagmite5Data::onBreak(%this, %obj) {
	(new Projectile() {
		datablock = Stalagmite5BrokenProjectile;
		initialPosition = %obj.getPosition();
		initialVelocity = "0 0 15";
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();
	%obj.setColliding(false);
	%obj.setDatablock(BrickStalagmite5BrokenData);
	serverPlay3dTimescale(StalagmiteBreakSound, %obj.getPosition(), getRandom(8, 12) / 10);
}

datablock fxDTSBrickData(BrickStalagmite4Data) {
	brickFile = "./bricks/stalagmite4.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Single Stalagmite, Small+Short ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalagmite4";
	isWaterBrick = false;

	isBreakable = true;
};

function BrickStalagmite4Data::onBreak(%this, %obj) {
	(new Projectile() {
		datablock = Stalagmite4BrokenProjectile;
		initialPosition = %obj.getPosition();
		initialVelocity = "0 0 15";
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();
	%obj.setColliding(false);
	%obj.setDatablock(BrickStalagmite4BrokenData);
	serverPlay3dTimescale(StalagmiteBreakSound, %obj.getPosition(), getRandom(8, 12) / 10);
}



function repairStalactites(%brickGroup) {
	%count = %brickGroup.getCount();
	for(%i = 0; %i < %count; %i++) {
		%brick = %brickGroup.getObject(%i);
		if(strPos(%brick.getDatablock().getName(), "Stalagmite") != -1 && strPos(%brick.getDatablock().getName(), "Broken") != -1) {
			switch$(%brick.getDatablock().getName()) {
				case "BrickStalagmite1BrokenData":
					%brick.setDatablock(BrickStalagmite1Data);
					%brick.setColliding(true);
				
				case "BrickStalagmite2BrokenData":
					%brick.setDatablock(BrickStalagmite2Data);
					%brick.setColliding(true);
				
				case "BrickStalagmite3BrokenData":
					%brick.setDatablock(BrickStalagmite3Data);
					%brick.setColliding(true);
				
				case "BrickStalagmite4BrokenData":
					%brick.setDatablock(BrickStalagmite4Data);
				
				case "BrickStalagmite5BrokenData":
					%brick.setDatablock(BrickStalagmite5Data);
					%brick.setColliding(true);
			}
		}
	}
}


datablock fxDTSBrickData(BrickStalactite1Data) {
	brickFile = "./bricks/stalactite1.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Stalactite Cluster ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalactite1";
	isWaterBrick = false;
};

datablock fxDTSBrickData(BrickStalactite2Data) {
	brickFile = "./bricks/stalactite2.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Single Stalactite, Large+Tall ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalactite2";
	isWaterBrick = false;
};

datablock fxDTSBrickData(BrickStalactite3Data) {
	brickFile = "./bricks/stalactite3.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Single Stalactite, Large+Short ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalactite3";
	isWaterBrick = false;
};

datablock fxDTSBrickData(BrickStalactite4Data) {
	brickFile = "./bricks/stalactite4.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Single Stalactite, Small+Tall ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalactite4";
	isWaterBrick = false;
};

datablock fxDTSBrickData(BrickStalactite5Data) {
	brickFile = "./bricks/stalactite5.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Single Stalactite, Small+Short ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalactite5";
	isWaterBrick = false;
};





datablock fxDTSBrickData(BrickStalagmite1BrokenData) {
	brickFile = "./bricks/stalagmite1broken.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalagmite1";
	isWaterBrick = false;
};

datablock fxDTSBrickData(BrickStalagmite2BrokenData) {
	brickFile = "./bricks/stalagmite2broken.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalagmite2";
	isWaterBrick = false;
};

datablock fxDTSBrickData(BrickStalagmite3BrokenData) {
	brickFile = "./bricks/stalagmite3broken.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalagmite3";
	isWaterBrick = false;
};

datablock fxDTSBrickData(BrickStalagmite5BrokenData) {
	brickFile = "./bricks/stalagmite5broken.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalagmite5";
	isWaterBrick = false;
};

datablock fxDTSBrickData(BrickStalagmite4BrokenData) {
	brickFile = "./bricks/stalagmite4broken.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/stalagmite4";
	isWaterBrick = false;
};
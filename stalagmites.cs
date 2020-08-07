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
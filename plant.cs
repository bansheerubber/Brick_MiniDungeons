datablock AudioProfile(PlantCutSound) {
	filename    = "./sounds/cut.ogg";
	description = AudioClose3d;
	preload = true;
};

datablock fxDTSBrickData(BrickBreakable3x4LeafData) {
	brickFile = "Add-Ons/Brick_WMPlants/3x4_Leaf.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Breakable 3x4 Leaf ";
	iconName = "Add-Ons/Brick_WMPlants/3x4_Leaf";

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickBreakable3x4LeafData::onBreak(%this, %obj, %col) {
	(new Projectile() {
		datablock = Leaf3x4BrokenProjectile;
		initialPosition = %obj.getPosition();
		initialVelocity = vectorScale(%col.getForwardVector(), 10);
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();

	serverPlay3dTimescale(PlantCutSound, %obj.getPosition(), getRandom(6, 14) / 10);

	%obj.delete();
}

datablock fxDTSBrickData(BrickBreakable5x6LeafData) {
	brickFile = "Add-Ons/Brick_WMPlants/5x6_Leaf.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Breakable 5x6 Leaf ";
	iconName = "Add-Ons/Brick_WMPlants/5x6_Leaf";

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickBreakable5x6LeafData::onBreak(%this, %obj, %col) {
	(new Projectile() {
		datablock = Leaf5x6BrokenProjectile;
		initialPosition = %obj.getPosition();
		initialVelocity = vectorScale(%col.getForwardVector(), 10);
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();

	serverPlay3dTimescale(PlantCutSound, %obj.getPosition(), getRandom(6, 14) / 10);

	%obj.delete();
}

datablock fxDTSBrickData(BrickBreakableSeagrassData) {
	brickFile = "Add-Ons/Brick_Plant/seagrass.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Breakable Seaweed ";
	iconName = "Add-Ons/Brick_Plant/seaweed";
	collisionShapeName = "Add-Ons/Brick_Plant/seagrass.dts";

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickBreakableSeagrassData::onBreak(%this, %obj, %col) {
	(new Projectile() {
		datablock = SeagrassBrokenProjectile;
		initialPosition = %obj.getPosition();
		initialVelocity = vectorScale(%col.getForwardVector(), 10);
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();

	serverPlay3dTimescale(PlantCutSound, %obj.getPosition(), getRandom(6, 14) / 10);

	%obj.delete();
}
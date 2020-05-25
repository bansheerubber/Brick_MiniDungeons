datablock AudioProfile(CrateBreakSound) {
	filename    = "./sounds/crate break.wav";
	description = AudioClose3d;
	preload = true;
};

datablock fxDTSBrickData(BrickWoodCrateData) {
	brickFile = "./bricks/wood crate.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Goodie Crate ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/wood crate";
	isWaterBrick = false;

	isBreakable = true;
};

function BrickWoodCrateData::onBreak(%this, %obj, %col) {
	%datablock = (%obj.angleId == 1 || %obj.angleId == 3) ? WoodCrateMasterProjectile : WoodCrateMasterRotProjectile;
	
	(new Projectile() {
		datablock = %datablock;
		initialPosition = vectorAdd(%obj.getPosition(), "0 0 0.4");
		initialVelocity = vectorScale(%col.getForwardVector(), 10);
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();

	serverPlay3dTimescale(CrateBreakSound, %obj.getPosition(), getRandom(8, 12) / 10);

	%obj.delete();
}
datablock fxDTSBrickData(BrickWoodBarrelData) {
	brickFile = "./bricks/wood barrel.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Goodie Barrel ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/wood barrel";
	isWaterBrick = false;

	isBreakable = true;
};

function BrickWoodBarrelData::onBreak(%this, %obj, %col) {
	(new Projectile() {
		datablock = WoodBarrelMasterProjectile;
		initialPosition = vectorAdd(%obj.getPosition(), "0 0 0.4");
		initialVelocity = vectorScale(%col.getForwardVector(), 10);
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();

	serverPlay3dTimescale(CrateBreakSound, %obj.getPosition(), getRandom(8, 12) / 10);

	spawnPickup(%obj.getPosition());

	%obj.delete();
}
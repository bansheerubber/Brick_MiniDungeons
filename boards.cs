datablock AudioProfile(BoardBreakSound) {
	filename    = "./sounds/board break2.ogg";
	description = AudioClose3d;
	preload = true;
};

datablock fxDTSBrickData(BrickLevelBoardData) {
	brickFile = "./bricks/board_level.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Level Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_level";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickLevelBoardData::onBreak(%this, %obj, %col) {
	switch(%obj.angleId) {
		case 0:
			%datablock = BoardBrokenAngle0Projectile;
			%vector = "0 1 0";
		
		case 1:
			%datablock = BoardBrokenAngle1Projectile;
			%vector = "1 0 0";
		
		case 2:
			%datablock = BoardBrokenAngle2Projectile;
			%vector = "0 1 0";
		
		case 3:
			%datablock = BoardBrokenAngle3Projectile;
			%vector = "1 0 0";
	}
	
	(new Projectile() {
		datablock = %datablock;
		initialPosition = %obj.getPosition();
		initialVelocity = vectorScale(%col.getForwardVector(), 10);
		sourceObject = 0;
		sourceSlot = 0;
	}).explode();

	serverPlay3dTimescale(BoardBreakSound, %obj.getPosition(), getRandom(8, 12) / 10);

	for(%i = -5.5 / 2; %i <= 5.5 / 2; %i += 5.5 / 2) {
		(new Projectile() {
			datablock = BoardChunkProjectile;
			initialPosition = vectorAdd(%obj.getPosition(), vectorScale(%vector, %i));
			initialVelocity = vectorScale(%obj.getForwardVector(), 10);
			sourceObject = 0;
			sourceSlot = 0;
		}).explode();
	}

	%obj.delete();
}

datablock fxDTSBrickData(BrickHighBoardData) {
	brickFile = "./bricks/board_high.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "High Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_high";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickHighBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickMidBoardData) {
	brickFile = "./bricks/board_mid.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Mid Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_mid";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickMidBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickLowBoardData) {
	brickFile = "./bricks/board_low.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Low Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_low";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickLowBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickNHighBoardData) {
	brickFile = "./bricks/board_nhigh.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Neg. High Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_nhigh";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickNHighBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickNMidBoardData) {
	brickFile = "./bricks/board_nmid.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Neg. Mid Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_nmid";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickNMidBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickNLowBoardData) {
	brickFile = "./bricks/board_nlow.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Neg. Low Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_nlow";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickNLowBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}



datablock fxDTSBrickData(BrickBLevelBoardData) {
	brickFile = "./bricks/b_board_level.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Behind Level Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_level";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickBLevelBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickBHighBoardData) {
	brickFile = "./bricks/b_board_high.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Behind High Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_high";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickBHighBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickBMidBoardData) {
	brickFile = "./bricks/b_board_mid.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Behind Mid Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_mid";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickBMidBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickBLowBoardData) {
	brickFile = "./bricks/b_board_low.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Behind Low Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_low";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickBLowBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickBNHighBoardData) {
	brickFile = "./bricks/b_board_nhigh.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Behind Neg. High Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_nhigh";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickBNHighBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickBNMidBoardData) {
	brickFile = "./bricks/b_board_nmid.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Behind Neg. Mid Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_nmid";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickBNMidBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}

datablock fxDTSBrickData(BrickBNLowBoardData) {
	brickFile = "./bricks/b_board_nlow.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Behind Neg. Low Board";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/board_nlow";
	isWaterBrick = true;

	isBreakable = true;
	forceSwingRadius = true;
};

function BrickBNLowBoardData::onBreak(%this, %obj, %col) {
	BrickLevelBoardData::onBreak(%this, %obj, %col);
}
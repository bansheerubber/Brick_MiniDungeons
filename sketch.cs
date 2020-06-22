datablock fxDTSBrickData(BrickStraightSketchData) {
	brickFile = "./bricks/straight_sketch.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Straight Sketch ";
	iconName = "";
	isSketchBrick = true;
};

datablock fxDTSBrickData(BrickCeilingSketchData) {
	brickFile = "./bricks/ceiling_sketch.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Ceiling Sketch ";
	iconName = "";
	isSketchBrick = false;
};

datablock fxDTSBrickData(BrickFloorSketchData) {
	brickFile = "./bricks/floor_sketch.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Floor Sketch ";
	iconName = "";
	isSketchBrick = false;
};

datablock fxDTSBrickData(BrickCornerSketchData) {
	brickFile = "./bricks/corner_sketch.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Corner Sketch ";
	iconName = "";
	isSketchBrick = true;
};

// used to differentiate between one kind of corner and another
datablock fxDTSBrickData(BrickCorner1SketchData) {
	brickFile = "./bricks/corner_sketch.blb";
	uiName = "Corner Sketch 1 ";
	isSketchBrick = true;
	isInteractable = true;
};

function BrickCorner1SketchData::onLook(%this, %brick, %player) {
	%player.client.centerPrint("|---", 0.3);
}

datablock fxDTSBrickData(BrickCorner2SketchData) {
	brickFile = "./bricks/corner_sketch.blb";
	uiName = "Corner Sketch 2 ";
	isSketchBrick = true;
	isInteractable = true;
};

function BrickCorner2SketchData::onLook(%this, %brick, %player) {
	%player.client.centerPrint("---|", 0.3);
}

// returns a vector to test along for corner 1. reverse the vector to test for corner 2
function cornerVectorHelper(%orientation) {
	if(%orientation == 0) {
		return "0 -1 0";
	}
	else if(%orientation == 1) {
		return "-1 0 0";
	}
	else if(%orientation == 2) {
		return "0 1 0";
	}
	else if(%orientation == 3) {
		return "1 0 0";
	}
}

function BrickCornerSketchData::onPlant(%this, %obj) {
	Parent::onPlant(%this, %obj);

	%this.determineCornerType(%obj);
}

function BrickCornerSketchData::determineCornerType(%this, %obj) {
	%start = %obj.getPosition();

	// test for corner 1
	%raycast = containerRaycast(
		%start,
		vectorAdd(
			%start,
			vectorScale(cornerVectorHelper(%obj.angleId), 8)
		),
		$TypeMasks::fxBrickObjectType,
		%obj
	);

	if(isObject(%raycast)) {
		%obj.setDatablock(BrickCorner1SketchData);
	}

	// test for corner 2
	%raycast = containerRaycast(
		%start,
		vectorAdd(
			%start,
			vectorScale(cornerVectorHelper(%obj.angleId), -8)
		),
		$TypeMasks::fxBrickObjectType,
		%obj
	);

	if(isObject(%raycast)) {
		%obj.setDatablock(BrickCorner2SketchData);
	}
}

// %direction & 1 means refresh down
// %direction & 2 means refresh up
function fxDTSBrickData::determineType(%this, %obj, %direction) {
	%upBrick = %obj.getUpBrick(0);
	%bottomBrick = %obj.getDownBrick(0);

	%hasBottomBrick = false;
	if(
		isObject(%bottomBrick)
		&& %bottomBrick.getDatablock().isSketchBrick
	) {
		%hasBottomBrick = true;
		// refresh bottom brick's type
		if(%direction & 1) {
			%this.determineType(%bottomBrick, 1);
		}
	}

	%hasUpBrick = false;
	if(
		isObject(%upBrick)
		&& %upBrick.getDatablock().isSketchBrick
	) {
		%hasUpBrick = true;
		// refresh bottom brick's type
		if(%direction & 2) {
			%this.determineType(%upBrick, 2);
		}
	}

	if(%hasBottomBrick && %hasUpBrick) {
		%obj.setColor(1);
	}
	else if(%hasBottomBrick) {
		%obj.setColor(2);
	}
	else {
		%obj.setColor(0);
	}
}

deActivatePackage(MiniDungeonsSketch);
package MiniDungeonsSketch {
	function fxDTSBrickData::onPlant(%this, %obj) {
		Parent::onPlant(%this, %obj);

		// determine if we're a bottom, middle, or top brick
		if(%this.isSketchBrick) {
			%this.determineType(%obj, 3);
		}
	}

	function fxDTSBrickData::onDeath(%this, %obj) {
		if(%obj.isPlanted && %this.isSketchBrick) {
			%upBrick = %obj.getUpBrick(0);
			%bottomBrick = %obj.getDownBrick(0);
		}
		
		Parent::onDeath(%this, %obj);

		if(%upBrick) {
			%this.determineType(%upBrick, 2);
		}

		if(%bottomBrick) {
			%this.determineType(%bottomBrick, 1);
		}
	}
};
activatePackage(MiniDungeonsSketch);
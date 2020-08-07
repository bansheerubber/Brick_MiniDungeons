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
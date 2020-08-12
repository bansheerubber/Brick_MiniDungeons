datablock fxDTSBrickData(BrickPotionRefillData) {
	brickFile = "./bricks/potion refill.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Potion Refill ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/potion refill";
	isWaterBrick = false;

	isInteractable = true;
};

function BrickPotionRefillData::onPlant(%this, %obj) {
	Parent::onPlant(%this, %obj);
	%obj.maxFluid = 100;
}

function BrickPotionRefillData::onLoadPlant(%this, %obj) {
	Parent::onLoadPlant(%this, %obj);
	%obj.maxFluid = 100;
}

function BrickPotionRefillData::onLook(%this, %obj, %interactee) {
	if(%obj.fluid[%interactee] $= "") {
		%obj.fluid[%interactee] = %obj.maxFluid;
	}
	
	%shown = %interactee.showPotionTransformUI(%obj.fluid[%interactee], %obj.maxFluid);
	if(%shown) {
		centerPrint(%interactee.client, "", 0.5);
		
		cancel(%interactee.hideRefillPotion);
		%interactee.hideRefillPotion = %interactee.schedule(200, hidePotionUI);
	}
	else {
		centerPrint(%interactee.client, "<color:ffff00><br><br>Potion Refilling Station", 0.5);
	}
}

function BrickPotionRefillData::onInteract(%this, %obj, %interactee) {
	if(%obj.fluid[%interactee] $= "") {
		%obj.fluid[%interactee] = %obj.maxFluid;
	}
	
	%refillAmount = %interactee.refillPotion(%obj.fluid[%interactee]);

	if(%refillAmount != -1) {
		%obj.fluid[%interactee] = mClamp(%obj.fluid[%interactee] - %refillAmount, 0, %obj.maxFluid);
		%interactee.client.play2d(errorSound);
	}
}
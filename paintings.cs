datablock fxDTSBrickData(BrickPictureFrameData) {
	brickFile = "./bricks/picture frame.blb";
	category = "Special";
	subCategory = "DUNGEONS!!!!!!!!";
	uiName = "Picture Frame ";
	iconName = "Add-Ons/Brick_MiniDungeons/icons/picture frame";
	isWaterBrick = false;
	hasPrint = true;
	printAspectRatio = "2x2f";

	isInteractable = true;
};

$MD::MaxPaintingNumber = 72;

function GameConnection::resetPaintings(%this) {
	deleteVariables("$MD::PaintingFound" @ %this.getBLID() @ "*");
	$MD::PaintingCount[%this.getBLID()] = 0;
}

function GameConnection::checkPaintingProgress(%this) {
	if(%this.getFoundPaintingsCount()) {
		%found = "\c4";
		%missing = "\c4";
		%missing2 = "\c4";
		for(%i = 1; %i <= $MD::MaxPaintingNumber; %i++) {
			if(%this.hasFoundPainting(%i)) {
				if(%consecutiveMissings != 0) {
					%dumpMissings = true;
				}

				if(%consecutiveFounds == 0) {
					%startFound = %i;
				}
				%consecutiveFounds++;
				%lastFound = %i;
			}
			else {
				if(%consecutiveFounds != 0) {
					%dumpFounds = true;
				}

				if(%consecutiveMissings == 0) {
					%startMissing = %i;
				}
				%consecutiveMissings++;
				%lastMissing = %i;
			}

			if(%dumpFounds) {
				%dumpFounds = false;

				if(%consecutiveFounds != 1) {
					%found = %found @ "#" @ %startFound @ "-" @ %lastFound @ ", ";	
				}
				else {
					%found = %found @ "#" @ %lastFound @ ", ";
				}

				%consecutiveFounds = 0;
			}

			if(%dumpMissings) {
				%dumpMissings = false;

				if(%consecutiveMissings != 1) {
					%missing = %missing @ "#" @ %startMissing @ "-" @ %lastMissing @ ", ";	
				}
				else {
					%missing = %missing @ "#" @ %lastMissing @ ", ";
				}

				%consecutiveMissings = 0;
			}
		}

		if(%consecutiveFounds != 0) {
			if(%consecutiveFounds != 1) {
				%found = %found @ "#" @ %startFound @ "-" @ %lastFound @ ", ";	
			}
			else {
				%found = %found @ "#" @ %lastFound @ ", ";
			}
		}

		if(%consecutiveMissings != 0) {
			if(%consecutiveMissings != 1) {
				%missing = %missing @ "#" @ %startMissing @ "-" @ %lastMissing @ ", ";	
			}
			else {
				%missing = %missing @ "#" @ %lastMissing @ ", ";
			}
		}

		messageClient(%this, '', "\c1You have found\c4" SPC %this.getFoundPaintingsCount() @ "/" @ $MD::MaxPaintingNumber SPC "\c4paintings. You have found the following paintings:");
		messageClient(%this, '', getSubStr(%found, 0, strLen(%found) - 2));
		messageClient(%this, '', "\c1You are missing:");
		messageClient(%this, '', getSubStr(%missing, 0, strLen(%missing) - 2));
	}
	else {
		messageClient(%this, '', "\c1You have not found any paintings yet. Click a painting to claim it as yours!");
	}
}

function serverCmdPaintings(%client) {
	%client.checkPaintingProgress();
}

function GameConnection::setPaintingFound(%this, %number) {
	$MD::PaintingFound[%this.getBLID(), %number] = true;
	$MD::PaintingCount[%this.getBLID()]++;
}

function GameConnection::hasFoundPainting(%this, %number) {
	return $MD::PaintingFound[%this.getBLID(), %number];
}

function GameConnection::getFoundPaintingsCount(%this) {
	return $MD::PaintingCount[%this.getBLID()];
}

function BrickPictureFrameData::onInteract(%this, %obj, %interactee) {
	%client = %interactee.client;
	%texture = getPrintTexture(%obj.getPrintId());
	%paintingNumber = fileBase(%texture);
	if(!%client.hasFoundPainting(%paintingNumber) && %paintingNumber $= (%paintingNumber | 0) && strPos(%texture, "Dungeon") != -1) {
		messageClient(%client, '', "\c1Congratulations! You have found painting \c4#" @ %paintingNumber SPC "\c1out of\c4" SPC $MD::MaxPaintingNumber @ "\c1!");
		%client.setPaintingFound(%paintingNumber);

		if(%client.getFoundPaintingsCount() == $MD::MaxPaintingNumber) {
			messageAll('MsgAdminForce', "<font:Arial bold:120><color:FFFF00>" @ strUpr(%client.getPlayerName()) SPC "HAS FOUND ALL THE PAINTINGS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
		}
	}
}

function BrickPictureFrameData::onLook(%this, %obj) {}
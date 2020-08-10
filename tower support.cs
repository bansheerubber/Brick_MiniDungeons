brick1x1x5Data.forceSwingRadius = true;
function brick1x1x5Data::onBrickDamageKilled(%this, %brick, %attacker, %damageType) {
	%split = trim(strReplace(%brick.getName(), "_", " "));
	%id = getWord(%split, 2);
	%index = getWord(%split, 1);

	// check all other bricks to see if we should kill the whole tower
	%count = 0;
	for(%i = 1; %i <= 4; %i++) {
		%testBrick = "_support_" @ %i @ "_" @ %id @ "_hp100";

		if(%testBrick.brickHp == 0 || !isObject(%testBrick)) {
			%count++;
		}
	}

	// if more than 2 supports are destroyed, knock down the entire tower
	if(%count >= 2) {
		%brick.getGroup().NTObjectCall("_cannon_breakable_" @ %id, "killBrick");
		
		for(%i = 1; %i <= 4; %i++) {
			%testBrick = "_support_" @ %i @ "_" @ %id @ "_hp100";
			%breakableBrick = "_support_breakable_" @ %id @ "_" @ %i;

			if(%testBrick.brickHp != 0 || isObject(%testBrick)) {
				%testBrick.getGroup().NTObjectCall(%breakableBrick, "killBrick");
				
				serverPlay3dTimescale(CrateBreakSound, %testBrick.getPosition(), getRandom(8, 12) / 10);

				(new Projectile() {
					datablock = BoardChunkProjectile;
					initialPosition = %testBrick.getPosition();
					initialVelocity = vectorScale(%attacker.getForwardVector(), 10);
					sourceObject = 0;
					sourceSlot = 0;
				}).explode();
				
				%testBrick.delete();
			}
		}
	}

	if(isObject(%brick)) {
		%brick.getGroup().NTObjectCall("_support_breakable_" @ %id @ "_" @ %index, "killBrick");

		serverPlay3dTimescale(CrateBreakSound, %brick.getPosition(), getRandom(8, 12) / 10);

		(new Projectile() {
			datablock = BoardChunkProjectile;
			initialPosition = %brick.getPosition();
			initialVelocity = vectorScale(%attacker.getForwardVector(), 10);
			sourceObject = 0;
			sourceSlot = 0;
		}).explode();

		%brick.delete();
	}
}

function brick1x1x5Data::brickDamage(%this, %brick, %attacker, %position, %damage, %damageType) {
	Parent::brickDamage(%this, %brick, %attacker, %position, %damage, %damageType);

	if(%brick.brickHp != 0) {
		serverPlay3dTimescale(BoardBreakSound, %brick.getPosition(), getRandom(8, 12) / 10);

		(new Projectile() {
			datablock = BoardChunkProjectile;
			initialPosition = %brick.getPosition();
			initialVelocity = vectorScale(%attacker.getForwardVector(), 10);
			sourceObject = 0;
			sourceSlot = 0;
		}).explode();
	}
}
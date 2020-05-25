function fxDTSBrickData::brickDamage(%this, %brick, %attacker, %position, %damage, %damageType) {
	%brick.brickHp = mClamp(%brick.brickHp - %damage, 0, %brick.brickMaxHp);

	if(%brick.brickHp == 0) {
		%this.onBrickDamageKilled(%brick, %attacker, %damageType);
	}
}

deActivatePackage(BrickDamage);
package BrickDamage {
	function fxDTSBrick::setName(%this, %name) {
		Parent::setName(%this, %name);

		if(strPos(%name, "hp") != -1) {
			%name = trim(strReplace(%name, "_", " "));
			%count = getWordCount(%name);
			for(%i = 0; %i < %count; %i++) {
				%word = getWord(%name, %i);
				if(strPos(%name, "hp") != -1) {
					%this.brickHp = strReplace(%word, "hp", "");
					%this.brickMaxHp = strReplace(%word, "hp", "");
				}
			}
		}
	}
};
activatePackage(BrickDamage);
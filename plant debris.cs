datablock ParticleData(PlantChunkParticle) {
	dragCoefficient      = 0;
	gravityCoefficient   = 2.0;
	inheritedVelFactor   = 0.0;
	constantAcceleration = 0.0;
	lifetimeMS           = 600;
	lifetimeVarianceMS   = 400;
	spinSpeed       	 = 0;
	spinRandomMin        = -600;
	spinRandomMax        = 600;

	textureName		= "base/data/particles/chunk.png";
	animateTexture	= true;
	framesPerSec	= 54;

	colors[0]	= "0.20 0.39 0.24 0.7";
	colors[1]	= "0.20 0.39 0.24 0.7";
	colors[2]	= "0.15 0.31 0.21 0.3";
	colors[3]	= "0.15 0.31 0.21 0.0";

	sizes[0]	= 0.7;
	sizes[1]	= 0.6;
	sizes[2]	= 0.2;
	sizes[3]	= 0.2;

	times[0]	= 0.0;
	times[1]	= 0.1;
	times[2]	= 0.5;
	times[3]	= 0.6;

	useInvAlpha = true;
};

datablock ParticleEmitterData(PlantChunkEmitter) {
	ejectionPeriodMS = 15;
	periodVarianceMS = 10;
	ejectionVelocity = 2;
	velocityVariance = 1;
	ejectionOffset   = 0.7;
	thetaMin         = 0;
	thetaMax         = 180;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	overrideAdvance = false;

	orientOnVelocity = false;
	orientParticles = false;

	particles = PlantChunkParticle;
};


datablock DebrisData(SeagrassBrokenDebris) {
	shapeFile = "./shapes/seagrass debris2.dts";

	emitters = "";

	lifetime = 5;
	minSpinSpeed = -200.0;
	maxSpinSpeed = 200.0;
	elasticity = 0.2;
	friction = 0;
	numBounces = 3;
	staticOnMaxBounce = true;
	snapOnMaxBounce = false;
	fade = true;

	gravModifier = 2;
};

datablock ExplosionData(SeagrassBrokenExplosion) {
	shakeCamera = false;

	emitter[0] = PlantChunkEmitter;

	lifeTimeMS = 100;

	shakeCamera = false;

	debris = SeagrassBrokenDebris;
	debrisNum = 1;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisVelocity = 5;
	debrisVelocityVariance = 3;

	soundProfile = "";
};

datablock ProjectileData(SeagrassBrokenProjectile) {
	explosion = SeagrassBrokenExplosion;
};




datablock DebrisData(Leaf3x4BrokenDebris : SeagrassBrokenDebris) {
	shapeFile = "./shapes/3x4 leaf debris.dts";
};

datablock ExplosionData(Leaf3x4BrokenExplosion : SeagrassBrokenExplosion) {
	debris = Leaf3x4BrokenDebris;
};

datablock ProjectileData(Leaf3x4BrokenProjectile) {
	explosion = Leaf3x4BrokenExplosion;
};




datablock DebrisData(Leaf5x6BrokenDebris : SeagrassBrokenDebris) {
	shapeFile = "./shapes/5x6 leaf debris.dts";
};

datablock ExplosionData(Leaf5x6BrokenExplosion : SeagrassBrokenExplosion) {
	debris = Leaf5x6BrokenDebris;
};

datablock ProjectileData(Leaf5x6BrokenProjectile) {
	explosion = Leaf5x6BrokenExplosion;
};
datablock ParticleData(StalagmiteParticle) {
	dragCoefficient      = 0;
	gravityCoefficient   = 1.0;
	inheritedVelFactor   = 0.0;
	constantAcceleration = 0.0;
	lifetimeMS           = 900;
	lifetimeVarianceMS   = 400;
	spinSpeed       	 = 0;
	spinRandomMin        = -600;
	spinRandomMax        = 600;

	textureName		= "base/data/particles/cloud.png";
	animateTexture	= true;
	framesPerSec	= 54;

	colors[0]	= "0.3 0.3 0.3 0.9";
	colors[1]	= "0.3 0.3 0.3 0.9";
	colors[2]	= "0.3 0.3 0.3 0.0";
	colors[3]	= "0.3 0.3 0.3 0.0";

	sizes[0]	= 1.0;
	sizes[1]	= 1.3;
	sizes[2]	= 2.3;
	sizes[3]	= 3.3;

	times[0]	= 0.0;
	times[1]	= 0.2;
	times[2]	= 0.5;
	times[3]	= 0.6;

	useInvAlpha = true;
};

datablock ParticleEmitterData(StalagmiteEmitter) {
	ejectionPeriodMS = 15;
	periodVarianceMS = 0;
	ejectionVelocity = 0;
	velocityVariance = 0;
	ejectionOffset   = 1;
	thetaMin         = 0;
	thetaMax         = 180;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	overrideAdvance = false;

	orientOnVelocity = false;
	orientParticles = false;

	particles = StalagmiteParticle;
};

datablock DebrisData(Stalagmite2BrokenDebris) {
	shapeFile = "./shapes/stalagtite2broken.dts";

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

datablock ExplosionData(Stalagmite2BrokenExplosion) {
	shakeCamera = false;

	emitter[0] = StalagmiteEmitter;

	lifeTimeMS = 100;

	shakeCamera = true;
	camShakeFreq = "2 2 2";
	camShakeAmp = "2 2 2";
	camShakeDuration = 1;
	camShakeRadius = 20;

	debris = Stalagmite2BrokenDebris;
	debrisNum = 1;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 15;
	debrisVelocity = 5;
	debrisVelocityVariance = 0;

	soundProfile = "";
};

datablock ProjectileData(Stalagmite2BrokenProjectile) {
	explosion = Stalagmite2BrokenExplosion;
};



datablock DebrisData(Stalagmite3BrokenDebris : Stalagmite2BrokenDebris) {
	shapeFile = "./shapes/stalagtite3broken.dts";
};

datablock ExplosionData(Stalagmite3BrokenExplosion : Stalagmite2BrokenExplosion) {
	debris = Stalagmite3BrokenDebris;
};

datablock ProjectileData(Stalagmite3BrokenProjectile) {
	explosion = Stalagmite3BrokenExplosion;
};



datablock DebrisData(Stalagmite4BrokenDebris : Stalagmite2BrokenDebris) {
	shapeFile = "./shapes/stalagtite4broken.dts";
};

datablock ExplosionData(Stalagmite4BrokenExplosion : Stalagmite2BrokenExplosion) {
	debris = Stalagmite4BrokenDebris;
};

datablock ProjectileData(Stalagmite4BrokenProjectile) {
	explosion = Stalagmite4BrokenExplosion;
};



datablock DebrisData(Stalagmite5BrokenDebris : Stalagmite2BrokenDebris) {
	shapeFile = "./shapes/stalagtite5broken.dts";
};

datablock ExplosionData(Stalagmite5BrokenExplosion : Stalagmite2BrokenExplosion) {
	debris = Stalagmite5BrokenDebris;
};

datablock ProjectileData(Stalagmite5BrokenProjectile) {
	explosion = Stalagmite5BrokenExplosion;
};



datablock DebrisData(Stalagmite1Part1BrokenDebris : Stalagmite2BrokenDebris) {
	shapeFile = "./shapes/stalagtite1part1broken.dts";
};

datablock DebrisData(Stalagmite1Part2BrokenDebris : Stalagmite2BrokenDebris) {
	shapeFile = "./shapes/stalagtite1part2broken.dts";
};

datablock DebrisData(Stalagmite1Part3BrokenDebris : Stalagmite2BrokenDebris) {
	shapeFile = "./shapes/stalagtite1part3broken.dts";
};

datablock DebrisData(Stalagmite1Part4BrokenDebris : Stalagmite2BrokenDebris) {
	shapeFile = "./shapes/stalagtite1part4broken.dts";
};

datablock ExplosionData(Stalagmite1Part1BrokenExplosion) {
	shakeCamera = false;

	debris = Stalagmite1Part1BrokenDebris;
	debrisNum = 1;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisVelocity = 5;
	debrisVelocityVariance = 3;

	subExplosion = "";
};

datablock ExplosionData(Stalagmite1Part2BrokenExplosion : Stalagmite1Part1Explosion) {
	debris = Stalagmite1Part2BrokenDebris;
};

datablock ExplosionData(Stalagmite1Part3BrokenExplosion : Stalagmite1Part1Explosion) {
	debris = Stalagmite1Part3BrokenDebris;
};

datablock ExplosionData(Stalagmite1BrokenExplosion) {
	shakeCamera = false;

	emitter[0] = StalagmiteEmitter;

	lifeTimeMS = 100;

	shakeCamera = true;
	camShakeFreq = "2 2 2";
	camShakeAmp = "2 2 2";
	camShakeDuration = 1;
	camShakeRadius = 20;

	debris = Stalagmite1Part4BrokenDebris;
	debrisNum = 1;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisVelocity = 5;
	debrisVelocityVariance = 3;

	soundProfile = "";

	subExplosion[0] = Stalagmite1Part1BrokenExplosion;
	subExplosion[1] = Stalagmite1Part2BrokenExplosion;
	subExplosion[2] = Stalagmite1Part3BrokenExplosion;
};

datablock ProjectileData(Stalagmite1BrokenProjectile) {
	explosion = Stalagmite1BrokenExplosion;
};
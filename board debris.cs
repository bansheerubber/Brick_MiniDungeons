datablock DebrisData(BoardBroken1Angle0Debris) {
	shapeFile = "./shapes/boards debris 1 angle id 0.dts";

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

datablock DebrisData(BoardBroken2Angle0Debris) {
	shapeFile = "./shapes/boards debris 2 angle id 0.dts";

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

datablock ExplosionData(BoardBrokenAngle0SubExplosion) {
	shakeCamera = false;

	debris = BoardBroken2Angle0Debris;
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

datablock ExplosionData(BoardBrokenAngle0Explosion) {
	shakeCamera = false;

	emitter[0] = "";

	lifeTimeMS = 100;

	shakeCamera = true;
	camShakeFreq = "0.5 0.5 0.5";
	camShakeAmp = "0.5 0.5 0.5";
	camShakeDuration = 1;
	camShakeRadius = 20;

	debris = BoardBroken1Angle0Debris;
	debrisNum = 1;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisVelocity = 5;
	debrisVelocityVariance = 3;

	soundProfile = "";

	subExplosion[0] = BoardBrokenAngle0SubExplosion;
};

datablock ProjectileData(BoardBrokenAngle0Projectile) {
	explosion = BoardBrokenAngle0Explosion;
};




datablock DebrisData(BoardBroken1Angle1Debris : BoardBroken1Angle0Debris) {
	shapeFile = "./shapes/boards debris 1 angle id 1.dts";
};

datablock DebrisData(BoardBroken2Angle1Debris : BoardBroken2Angle0Debris) {
	shapeFile = "./shapes/boards debris 2 angle id 1.dts";
};

datablock ExplosionData(BoardBrokenAngle1SubExplosion : BoardBrokenAngle0SubExplosion) {
	debris = BoardBroken2Angle1Debris;
};

datablock ExplosionData(BoardBrokenAngle1Explosion : BoardBrokenAngle0Explosion) {
	debris = BoardBroken1Angle1Debris;
	subExplosion[0] = BoardBrokenAngle1SubExplosion;
};

datablock ProjectileData(BoardBrokenAngle1Projectile) {
	explosion = BoardBrokenAngle1Explosion;
};




datablock DebrisData(BoardBroken1Angle2Debris : BoardBroken1Angle0Debris) {
	shapeFile = "./shapes/boards debris 1 angle id 2.dts";
};

datablock DebrisData(BoardBroken2Angle2Debris : BoardBroken2Angle0Debris) {
	shapeFile = "./shapes/boards debris 2 angle id 2.dts";
};

datablock ExplosionData(BoardBrokenAngle2SubExplosion : BoardBrokenAngle0SubExplosion) {
	debris = BoardBroken2Angle2Debris;
};

datablock ExplosionData(BoardBrokenAngle2Explosion : BoardBrokenAngle0Explosion) {
	debris = BoardBroken1Angle2Debris;
	subExplosion[0] = BoardBrokenAngle2SubExplosion;
};

datablock ProjectileData(BoardBrokenAngle2Projectile) {
	explosion = BoardBrokenAngle2Explosion;
};




datablock DebrisData(BoardBroken1Angle3Debris : BoardBroken1Angle0Debris) {
	shapeFile = "./shapes/boards debris 1 angle id 3.dts";
};

datablock DebrisData(BoardBroken2Angle3Debris : BoardBroken2Angle0Debris) {
	shapeFile = "./shapes/boards debris 2 angle id 3.dts";
};

datablock ExplosionData(BoardBrokenAngle3SubExplosion : BoardBrokenAngle0SubExplosion) {
	debris = BoardBroken2Angle3Debris;
};

datablock ExplosionData(BoardBrokenAngle3Explosion : BoardBrokenAngle0Explosion) {
	debris = BoardBroken1Angle3Debris;
	subExplosion[0] = BoardBrokenAngle3SubExplosion;
};

datablock ProjectileData(BoardBrokenAngle3Projectile) {
	explosion = BoardBrokenAngle3Explosion;
};





datablock ParticleData(BoardChunkParticle) {
	dragCoefficient      = 0;
	gravityCoefficient   = 2.0;
	inheritedVelFactor   = 0.0;
	constantAcceleration = 0.0;
	lifetimeMS           = 1500;
	lifetimeVarianceMS   = 700;
	spinSpeed       	 = 0;
	spinRandomMin        = -600;
	spinRandomMax        = 600;

	textureName		= "base/data/particles/chunk.png";
	animateTexture	= true;
	framesPerSec	= 54;

	colors[0]	= "0.50 0.34 0.24 0.7";
	colors[1]	= "0.50 0.34 0.24 0.7";
	colors[2]	= "0.36 0.20 0.13 0.3";
	colors[3]	= "0.36 0.20 0.13 0.0";

	sizes[0]	= 1.3;
	sizes[1]	= 1.3;
	sizes[2]	= 0.8;
	sizes[3]	= 0.3;

	times[0]	= 0.0;
	times[1]	= 0.1;
	times[2]	= 0.5;
	times[3]	= 0.6;

	useInvAlpha = true;
};

datablock ParticleEmitterData(BoardChunkEmitter) {
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

	particles = BoardChunkParticle;
};

datablock ExplosionData(BoardChunkExplosion) {
	emitter[0] = BoardChunkEmitter;
	lifeTimeMS = 100;
};

datablock ProjectileData(BoardChunkProjectile) {
	explosion = BoardChunkExplosion;
};
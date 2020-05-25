datablock DebrisData(WoodCrate2Debris) {
	shapeFile = "./shapes/wood crate debris 2.dts";

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

datablock ExplosionData(WoodCrate2Explosion) {
	shakeCamera = false;

	emitter[0] = "";

	lifeTimeMS = 100;

	shakeCamera = true;
	camShakeFreq = "0.5 0.5 0.5";
	camShakeAmp = "0.5 0.5 0.5";
	camShakeDuration = 1;
	camShakeRadius = 20;

	debris = WoodCrate2Debris;
	debrisNum = 9;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisVelocity = 8;
	debrisVelocityVariance = 5;

	offset = 0.2;

	soundProfile = "";
};







datablock DebrisData(WoodCrate1Debris) {
	shapeFile = "./shapes/wood crate debris 1.dts";

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

datablock ExplosionData(WoodCrate1Explosion) {
	shakeCamera = false;

	emitter[0] = "";

	lifeTimeMS = 100;

	shakeCamera = true;
	camShakeFreq = "0.5 0.5 0.5";
	camShakeAmp = "0.5 0.5 0.5";
	camShakeDuration = 1;
	camShakeRadius = 20;

	debris = WoodCrate1Debris;
	debrisNum = 1;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisVelocity = 8;
	debrisVelocityVariance = 5;

	offset = 0.5;

	soundProfile = "";
};







datablock DebrisData(WoodCrate3Debris) {
	shapeFile = "./shapes/wood crate debris 3.dts";

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

datablock ExplosionData(WoodCrate3Explosion) {
	shakeCamera = false;

	emitter[0] = "";

	lifeTimeMS = 100;

	shakeCamera = true;
	camShakeFreq = "0.5 0.5 0.5";
	camShakeAmp = "0.5 0.5 0.5";
	camShakeDuration = 1;
	camShakeRadius = 20;

	debris = WoodCrate3Debris;
	debrisNum = 1;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisVelocity = 8;
	debrisVelocityVariance = 5;

	offset = 1;

	soundProfile = "";
};






datablock ParticleData(CrateParticle) {
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

datablock ParticleEmitterData(CrateEmitter) {
	ejectionPeriodMS = 10;
	periodVarianceMS = 5;
	ejectionVelocity = 3;
	velocityVariance = 2;
	ejectionOffset   = 1;
	thetaMin         = 0;
	thetaMax         = 180;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	overrideAdvance = false;

	orientOnVelocity = false;
	orientParticles = false;

	particles = CrateParticle;
};

datablock ExplosionData(WoodCrateMasterExplosion) {
	shakeCamera = false;

	emitter[0] = CrateEmitter;

	lifeTimeMS = 100;

	subExplosion[0] = WoodCrate3Explosion;
	subExplosion[1] = WoodCrate3Explosion;
	subExplosion[2] = WoodCrate1Explosion;
	subExplosion[3] = WoodCrate1Explosion;
	subExplosion[4] = WoodCrate2Explosion;
	subExplosion[5] = WoodCrate2Explosion;
	subExplosion[6] = WoodCrate2Explosion;

	soundProfile = "";
};

datablock ProjectileData(WoodCrateMasterProjectile) {
	explosion = WoodCrateMasterExplosion;
};





















datablock DebrisData(WoodCrate2RotDebris) {
	shapeFile = "./shapes/wood crate debris 2 rot.dts";

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

datablock ExplosionData(WoodCrate2RotExplosion) {
	shakeCamera = false;

	emitter[0] = "";

	lifeTimeMS = 100;

	shakeCamera = true;
	camShakeFreq = "0.5 0.5 0.5";
	camShakeAmp = "0.5 0.5 0.5";
	camShakeDuration = 1;
	camShakeRadius = 20;

	debris = WoodCrate2RotDebris;
	debrisNum = 9;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisVelocity = 8;
	debrisVelocityVariance = 5;

	offset = 0.2;

	soundProfile = "";
};







datablock DebrisData(WoodCrate1RotDebris) {
	shapeFile = "./shapes/wood crate debris 1 rot.dts";

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

datablock ExplosionData(WoodCrate1RotExplosion) {
	shakeCamera = false;

	emitter[0] = "";

	lifeTimeMS = 100;

	shakeCamera = true;
	camShakeFreq = "0.5 0.5 0.5";
	camShakeAmp = "0.5 0.5 0.5";
	camShakeDuration = 1;
	camShakeRadius = 20;

	debris = WoodCrate1RotDebris;
	debrisNum = 1;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisVelocity = 8;
	debrisVelocityVariance = 5;

	offset = 0.5;

	soundProfile = "";
};







datablock DebrisData(WoodCrate3RotDebris) {
	shapeFile = "./shapes/wood crate debris 3 rot.dts";

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

datablock ExplosionData(WoodCrate3RotExplosion) {
	shakeCamera = false;

	emitter[0] = "";

	lifeTimeMS = 100;

	shakeCamera = true;
	camShakeFreq = "0.5 0.5 0.5";
	camShakeAmp = "0.5 0.5 0.5";
	camShakeDuration = 1;
	camShakeRadius = 20;

	debris = WoodCrate3RotDebris;
	debrisNum = 1;
	debrisNumVariance = 0;
	debrisPhiMin = 0;
	debrisPhiMax = 360;
	debrisThetaMin = 0;
	debrisThetaMax = 60;
	debrisVelocity = 8;
	debrisVelocityVariance = 5;

	offset = 1;

	soundProfile = "";
};







datablock ExplosionData(WoodCrateMasterRotExplosion) {
	shakeCamera = false;

	emitter[0] = CrateEmitter;

	lifeTimeMS = 100;

	shakeCamera = true;
	camShakeFreq = "2 2 2";
	camShakeAmp = "2 2 2";
	camShakeDuration = 1;
	camShakeRadius = 20;

	subExplosion[0] = WoodCrate3RotExplosion;
	subExplosion[1] = WoodCrate3RotExplosion;
	subExplosion[2] = WoodCrate1RotExplosion;
	subExplosion[3] = WoodCrate1RotExplosion;
	subExplosion[4] = WoodCrate2RotExplosion;
	subExplosion[5] = WoodCrate2RotExplosion;
	subExplosion[6] = WoodCrate2RotExplosion;

	soundProfile = "";
};

datablock ProjectileData(WoodCrateMasterRotProjectile) {
	explosion = WoodCrateMasterRotExplosion;
};
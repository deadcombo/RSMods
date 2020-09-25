#pragma once
#include "../CCEffect.hpp"

namespace CrowdControl::Effects {
	class FYourFCEffect : public CCEffect
	{
	public:
		FYourFCEffect(unsigned int durationSeconds) {
			duration = durationSeconds;
		}

		EffectResult Test();
		EffectResult Start();
		void Run();
		EffectResult Stop();
	};
}
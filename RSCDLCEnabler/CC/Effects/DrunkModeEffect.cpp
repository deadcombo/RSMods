#include "DrunkModeEffect.hpp"

using namespace CrowdControl::Enums;

namespace CrowdControl::Effects { // Makes some of game's object very woobly (lyrics, backgrounds, etc.)
	EffectResult DrunkModeEffect::Test(Request request)
	{
		std::cout << "DrunkModeEffect::Test()" << std::endl;

		if (!MemHelpers::IsInSong() || running)
			return EffectResult::Retry;

		return EffectResult::Success;
	}

	EffectResult DrunkModeEffect::Start(Request request)
	{
		std::cout << "DrunkModeEffect::Start()" << std::endl;

		if (!MemHelpers::IsInSong() || running)
			return EffectResult::Retry;

		running = true;

		Settings::UpdateTwitchSetting("DrunkMode", "on");
		MemHelpers::ToggleDrunkMode(true);

		SetDuration(request);
		endTime = std::chrono::steady_clock::now() + std::chrono::seconds(duration);

		return EffectResult::Success;
	}

	void DrunkModeEffect::Run()
	{
		// Stop automatically after duration has elapsed
		if (running) {
			auto now = std::chrono::steady_clock::now();
			std::chrono::duration<double> duration = (endTime - now);

			if (duration.count() <= 0) Stop();
		}
	}

	EffectResult DrunkModeEffect::Stop()
	{
		std::cout << "DrunkModeEffect::Stop()" << std::endl;

		running = false;
		MemHelpers::ToggleDrunkMode(false);
		Settings::UpdateTwitchSetting("DrunkMode", "off");

		return EffectResult::Success;
	}
}

﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Taiko.Objects;

namespace osu.Game.Rulesets.Taiko.Mods
{
    public class TaikoModNightcore : ModNightcore<TaikoHitObject>
    {
        public override double ScoreMultiplier => UsesDefaultConfiguration ? 1.12 : 1;
    }
}
